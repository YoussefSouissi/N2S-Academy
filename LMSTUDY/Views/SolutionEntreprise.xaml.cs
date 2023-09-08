namespace LMSTUDY.Views;

public partial class SolutionEntreprise : ContentPage
{
    public SolutionEntreprise()
    {
        InitializeComponent();
    }
    private async void BackToHomePage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new HomePage());

    }

    private async void ToAvantages(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new SolutionEnpAvantages());
    }
}