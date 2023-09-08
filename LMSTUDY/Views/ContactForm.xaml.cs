namespace LMSTUDY.Views;

public partial class ContactForm : ContentPage
{
	public ContactForm()
	{
		InitializeComponent();
	}
    private void OnSubmitClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NomEntry.Text) ||
            string.IsNullOrWhiteSpace(EmailEntry.Text) ||
            string.IsNullOrWhiteSpace(PhoneEntry.Text) ||
            string.IsNullOrWhiteSpace(AdressEntry.Text) ||
            string.IsNullOrWhiteSpace(CodePostEntry.Text) ||
            string.IsNullOrWhiteSpace(VilleEntry.Text) ||
             string.IsNullOrWhiteSpace(PaysEntry.Text) 
               

             )
          
        {

            DisplayAlert("Erreur", "Veuillez remplir tous les champs obligatoires.", "OK");

        }
        
    }

    [Obsolete]
    private void MsgEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        var lineHeight = Device.GetNamedSize(NamedSize.Medium, entry);
        var numLines = e.NewTextValue.Split('\n').Length;
        entry.HeightRequest = lineHeight * numLines;
    }

    private async void BackToAvantages(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new SolutionEnpAvantages());
    }


}