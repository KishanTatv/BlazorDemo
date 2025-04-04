﻿namespace SMS.Shared.Static.Constants
{
    public static class HttpResponseMessages
    {
        public static string msgHttpConnectionFailed = "Failed to connect with Http to make requests";
        public static string msgHttpRequestFailed = "Failed to get Http Response";
        public static string msgNotFound = "Failed to get Http Response";
    }

    public static class SystemMessage
    {
        public static string msgSomethingWrong = "Something Wrong !";
        public static string msgTryAgain = "Plaese try again !";
    }

    public static class DateFormat
    {
        public static string ddMMMyyyy = "dd MMM, yyyy";
        public static string MMMMyyyy = "MMMM yyyy";
    }



    //regEx
    public static class FormRegEx
    {
        public const string OnlyString = @"^[a-zA-Z]+$";
        public const string Phone = @"^(\d{10})$";
        public const string ZipCode = @"^\d{6}(-\d{4})?$";
    }

    public static class ErrorMessage
    {
        public const string RequiredMsg = "{0} feild is required.";
        public const string InValidMsg = "please enter a valid {0} feild.";
        public const string OnlyAlphabetMsg = "please enter only alphabets.";
        public const string WrongLengthMsg = "{0} length must be between 2 and 25 character.";
    }
}
