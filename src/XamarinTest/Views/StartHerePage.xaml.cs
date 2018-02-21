using System;
using ViewModels.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartHerePage : ContentPage
	{
		public StartHerePage()
		{
			InitializeComponent();

            Icon.Clicked += IconOnClicked;
		    Button0.Clicked += CalculatorButtonOnClicked;
		    Button1.Clicked += CalculatorButtonOnClicked;
		    Button2.Clicked += CalculatorButtonOnClicked;
		    Button3.Clicked += CalculatorButtonOnClicked;
		    Button4.Clicked += CalculatorButtonOnClicked;
		    Button5.Clicked += CalculatorButtonOnClicked;
		    Button6.Clicked += CalculatorButtonOnClicked;
		    Button7.Clicked += CalculatorButtonOnClicked;
		    Button8.Clicked += CalculatorButtonOnClicked;
		    Button9.Clicked += CalculatorButtonOnClicked;
		    ButtonPlus.Clicked += CalculatorButtonOnClicked;
		    ButtonMinus.Clicked += CalculatorButtonOnClicked;
		    ButtonEqual.Clicked += CalculatorButtonOnClicked;
		    ButtonDelete.Clicked += CalculatorButtonOnClicked;
        }

	    private void CalculatorButtonOnClicked(object sender, EventArgs eventArgs)
	    {
	        var button = (Button) sender;

            ViewModel.Calculate(button.Text);
	        ResultEntry.Text = ViewModel.OutputResult;
	    }

	    private StartHerePageViewModel ViewModel => (StartHerePageViewModel)this.BindingContext;

        private void IconOnClicked(object sender, EventArgs eventArgs)
	    {
	        ViewModel.NavigateToManualPage();
        }
	}
}
