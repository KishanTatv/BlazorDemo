namespace SMS.Shared.Loader
{
    public class LoaderService
    {
        public event Action<bool>? OnLoaderStateChanged;

        public void ShowLoader()
        {
            OnLoaderStateChanged?.Invoke(true);
        }

        public async void HideLoader()
        {
            await Task.Delay(500);
            OnLoaderStateChanged?.Invoke(false);
        }
    }

}
