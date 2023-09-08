using LMSTUDY.ViewModels;

namespace LMSTUDY.Views;

public partial class SolutionEnpAvantages : ContentPage
{
	public SolutionEnpAvantages()
	{
		InitializeComponent();
        this.BindingContext = new AvantagesViewModel();
    }

    private async void ToForm(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ContactForm());
    }

    private async void BackToSolutionEnp(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new SolutionEntreprise());
    }
}