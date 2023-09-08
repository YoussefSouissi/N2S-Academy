namespace LMSTUDY.Views;

public partial class UserProfile : ContentPage
{
	public UserProfile()
	{
		InitializeComponent();
	}
   
    private async void ToContactPage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ContactPage());
    }
    private async void ToPanierPage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new PanierPage());
    }
    private async void ToHomePage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new HomePage());
    }
}