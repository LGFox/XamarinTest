using System;
using System.Threading.Tasks;
using DataStructures.Enums;
using Interfaces.PlatformServices;
using Interfaces.Services;
using Prism.Navigation;
using Prism.Services;

namespace ViewModels.ViewModels.Base
{
    public abstract class NavigationBaseViewModel : BaseViewModel, INavigationAware, IConfirmNavigation, IDestructible
    {
        public NavigationBaseViewModel(INavigationService navigationService,
            IDeviceService deviceService,
            IUserDialogService userDialogService,
            IPlaySoundService playSoundService)
        {
            NavigationService = navigationService;
            DeviceService = deviceService;
            UserDialogService = userDialogService;
            PlaySoundService = playSoundService;
        }

        protected async Task NavigateToUri(string uri)
        {
            if (string.IsNullOrWhiteSpace(uri))
            {
                throw new ArgumentException("Value cannot be null or white space.", nameof(uri));
            }

            try
            {
                DeviceService.BeginInvokeOnMainThread(async () =>
                {
                    PlaySoundService.PlaySound(AppSoundsEnum.DigitalButton);
                    await NavigationService.NavigateAsync(uri, useModalNavigation: false);
                });
            }
            catch (Exception ex)
            {
                await HandleException(ex);
            }
        }

        protected virtual async Task HandleException(Exception ex)
        {
            var baseException = ex.GetBaseException();
            await UserDialogService.AlertAsync(baseException.Message);

        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        public virtual bool CanNavigate(NavigationParameters parameters)
        {
            return true;
        }

        public virtual void Destroy()
        {
        }

        protected INavigationService NavigationService { get; }

        protected IDeviceService DeviceService { get; }

        protected IUserDialogService UserDialogService { get; }

        protected IPlaySoundService PlaySoundService { get; }
    }
}