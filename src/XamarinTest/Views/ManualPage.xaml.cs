﻿using System;
using ViewModels.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTest.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ManualPage : ContentPage
	{
		public ManualPage ()
		{
			InitializeComponent ();
		    Icon.Clicked += IconOnClicked;
        }

	    private ManualPageViewModel ViewModel => (ManualPageViewModel)this.BindingContext;

        private void IconOnClicked(object sender, EventArgs eventArgs)
	    {
	        ViewModel.NavigateToManualPage();
	    }
    }
}