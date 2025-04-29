using Microsoft.AspNetCore.Components.Forms;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web;

namespace SMS.Shared.HttpManager.Utility
{
    public static class UrlBuilderUtility
    {
        public static string GetCombineUrl(string endPoint, string baseURL)
        {
            return Path.Combine(baseURL, endPoint);
        }

        public static string GenerateQueryStringFromDTO<T>(T viewModel)
        {
            if (viewModel == null)
                return string.Empty;

            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var parameters = new List<KeyValuePair<string, string>>();

            foreach (var property in properties)
            {
                var value = property.GetValue(viewModel);

                if (value != null)
                {
                    string stringValue;
                    if (property.PropertyType == typeof(DateTime?) || property.PropertyType == typeof(DateTime))
                    {
                        stringValue = ((DateTime)value).ToString("yyyy-MM-ddTHH:mm:ss");
                    }
                    else
                    {
                        stringValue = value.ToString();
                    }

                    if (!string.IsNullOrEmpty(property.Name) && !string.IsNullOrEmpty(stringValue))
                    {
                        parameters.Add(new KeyValuePair<string, string>(property.Name, stringValue));
                    }
                }
            }
            return GenerateQueryString(parameters);
        }

        public static string GenerateQueryString(List<KeyValuePair<string, string>> parameters)
        {
            parameters = parameters.Where(x => !string.IsNullOrEmpty(x.Key) && !string.IsNullOrEmpty(x.Value) && !string.IsNullOrWhiteSpace(x.Key) && !string.IsNullOrWhiteSpace(x.Value)).ToList();
            if (parameters == null || !parameters.Any())
                return string.Empty;

            var query = HttpUtility.ParseQueryString(string.Empty);
            foreach (KeyValuePair<string, string> param in parameters)
            {
                query[param.Key] = param.Value;
            }

            return $"?{query}";
        }
    }


    public static class FormDataUtility
    {
        public static MultipartFormDataContent ConvertToMultipartFormData<T>(T model)
        {
            var formData = new MultipartFormDataContent();
            var properties = typeof(T).GetProperties();

            foreach (var prop in properties)
            {
                var value = prop.GetValue(model);

                if (value == null) continue;

                if (value is IBrowserFile file)
                {
                    var fileStream = file.OpenReadStream(maxAllowedSize: 1024 * 1024 * 10, cancellationToken: CancellationToken.None);
                    var fileContent = new StreamContent(fileStream);
                    fileContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
                    formData.Add(fileContent, prop.Name, file.Name);
                }
                else if (value is List<IBrowserFile> files)
                {
                    foreach(var fileItem in files)
                    {
                        var fileStream = fileItem.OpenReadStream(maxAllowedSize: 1024 * 1024 * 10, cancellationToken: CancellationToken.None);
                        var fileContent = new StreamContent(fileStream);
                        fileContent.Headers.ContentType = new MediaTypeHeaderValue(fileItem.ContentType);
                        formData.Add(fileContent, prop.Name, fileItem.Name);
                    }
                }
                else
                {
                    formData.Add(new StringContent(value.ToString()), prop.Name);
                }
            }

            return formData;
        }
    }
}
