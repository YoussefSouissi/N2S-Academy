using LMSTUDY.ViewModels;

namespace LMSTUDY.Views;

public partial class IntroScreenView : ContentPage
{
	public IntroScreenView()
	{
		InitializeComponent();
		this.BindingContext = new IntroScreenViewModel();
	}

    private async void StartButton_Clicked(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new SignupPage());
    }


}