namespace LMSTUDY.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    

    private void EyeIcon_Tapped2(object sender, EventArgs e)
    {
        PwdEntry.IsPassword = !PwdEntry.IsPassword;
    }

    private void OnEmailEntryUnfocused(object sender, FocusEventArgs e)
    {
        string enteredEmail = EmailEntry.Text;

        if (IsValidEmail(enteredEmail))
        {
            EmailErrorLabel.IsVisible = false;
        }
        else
        {
            EmailErrorLabel.IsVisible = true;
        }
    }

    private bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        string[] parts = email.Split('@');
        if (parts.Length != 2)
            return false;

        string personalInfo = parts[0];
        if (string.IsNullOrWhiteSpace(personalInfo))
            return false;


        string domain = parts[1];
        if (string.IsNullOrWhiteSpace(domain))
            return false;

        string domainPattern = @"^[a-zA-Z0-9.-]+$";
        if (!System.Text.RegularExpressions.Regex.IsMatch(domain, domainPattern))
            return false;


        if (!domain.Contains("."))
            return false;


        string tldPattern = @"^[a-zA-Z]{2,4}$";
        string[] domainParts = domain.Split('.');
        if (domainParts.Length < 2 || domainParts[^1].Length < 2 || domainParts[^1].Length > 4 || !System.Text.RegularExpressions.Regex.IsMatch(domainParts[^1], tldPattern))
            return false;

        return true;
    }

    private async void OnLabelTapped(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new SignupPage());
    }
    private async void ToHomePage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new HomePage());
    }
    
}