namespace LMSTUDY.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }
    private async void ViewCategories(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Categories());

    }
    private async void SolutionEntreprise(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new SolutionEntreprise());
    }

    private async void ToContactPage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ContactPage());
    }
    private async void ToUserPage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new UserProfile());
    }

    private async void ToFinancerFormation(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new FinancerSaFormation());
    }

    private async void ToPanierPage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new PanierPage());
    }
}