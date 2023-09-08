namespace LMSTUDY.Views;

public partial class FormationPage : ContentPage
{
	public FormationPage()
	{
		InitializeComponent();
	}

    private async void BackToHomePage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new HomePage());
    }
}