using BlazorBootstrap;
using Microsoft.AspNetCore.Components;

namespace SMS.Shared.Loader
{
    public class LoaderService
    {

        private PreloadService? _preloadService;
        public event Action? OnLoaderStateChanged;
        public void Initialize(PreloadService preloadService)
        {
            _preloadService = preloadService;
        }

        public void ShowLoader()
        {
            _preloadService?.Show();
            OnLoaderStateChanged?.Invoke(); 
        }

        public async void HideLoader()
        {
            await Task.Delay(1600); 
            _preloadService?.Hide();
            OnLoaderStateChanged?.Invoke(); 
        }
    }

}
