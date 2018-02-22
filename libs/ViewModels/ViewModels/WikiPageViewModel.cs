using DataStructures.Enums;
using Interfaces.PlatformServices;
using Prism.Navigation;
using Prism.Services;
using ViewModels.ViewModels.Base;

namespace ViewModels.ViewModels
{
    public class WikiPageViewModel : NavigationBaseViewModel
    {
        public WikiPageViewModel(INavigationService navigationService,
            IDeviceService deviceService, 
            IUserDialogService userDialogService,
            IPlaySoundService playSoundService)
            : base(navigationService, deviceService, userDialogService, playSoundService)
        {
        }

        public async void NavigateToManualPage()
        {
            await NavigateToUri(nameof(AppPagesEnum.ManualPage));
        }
    }
}