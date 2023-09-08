namespace LMSTUDY.Views;

public partial class FinanceForm : ContentPage

{
	public FinanceForm()
	{
		InitializeComponent();
	}
    private async void BackToFinance(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new FinancerSaFormation());

    }

   
}