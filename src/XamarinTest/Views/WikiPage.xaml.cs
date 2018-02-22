using System;
using ViewModels.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTest.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WikiPage : ContentPage
	{
		public WikiPage ()
		{
			InitializeComponent ();
		    Icon.Clicked += IconOnClicked;
        }
        
	    private WikiPageViewModel ViewModel => (WikiPageViewModel)this.BindingContext;

	    private void IconOnClicked(object sender, EventArgs eventArgs)
	    {
	        ViewModel.NavigateToManualPage();
	    }
    }
}