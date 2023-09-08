namespace LMSTUDY.Views;

public partial class FinancerSaFormation : ContentPage
{
	public FinancerSaFormation()
	{
		InitializeComponent();
	}
    private async void BackToHomePage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new HomePage());

    }

    private async void ToFinanceForm(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new FinanceForm());

    }
}