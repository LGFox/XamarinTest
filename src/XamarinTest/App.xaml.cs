using Interfaces.PlatformServices;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using ServiceLocator;
using ViewModels.ViewModels;
using Xamarin.Forms;
using XamarinTest.PlatformServices;
using XamarinTest.Views;

namespace XamarinTest
{
	public partial class App : PrismApplication
	{
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
        }

	    protected override void RegisterTypes(IContainerRegistry containerRegistry)
	    {
	        containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<StartHerePage, StartHerePageViewModel>();
	        containerRegistry.RegisterForNavigation<ManualPage, ManualPageViewModel>();
	        containerRegistry.RegisterForNavigation<WikiPage, WikiPageViewModel>();

            containerRegistry.RegisterSingleton<ISettingService, SettingService>();
	        containerRegistry.RegisterSingleton<IUserDialogService, UserDialogService>();
            containerRegistry.RegisterSingleton<IPlaySoundService, PlaySoundService>();

            ServicesInitializer.Initialize(containerRegistry, Container);
	    }

	    protected override async void OnInitialized()
	    {
	        InitializeComponent();
            
	        await NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(StartHerePage)}");
        }

	    protected override void OnStart ()
		{
			// Handle when your app starts
		}

	    protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

	    protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
