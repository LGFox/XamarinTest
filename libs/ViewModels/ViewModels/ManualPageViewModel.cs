using Interfaces.PlatformServices;
using Prism.Navigation;
using Prism.Services;
using ViewModels.ViewModels.Base;

namespace ViewModels.ViewModels
{
    public class ManualPageViewModel : NavigationBaseViewModel
    {
        public ManualPageViewModel(INavigationService navigationService,
            IDeviceService deviceService,
            IUserDialogService userDialogService,
            IPlaySoundService playSoundService)
            : base(navigationService, deviceService, userDialogService, playSoundService)
        {
        }
    }
}