namespace LMSTUDY.Views;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();
	}

    private async void ToHomePage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new HomePage());
    }

    private async void ToUserPage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new UserProfile());
    }

    private async void ToContactForm(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ContactForm());
    }
    private async void ToPanierPage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new PanierPage());
    }

}