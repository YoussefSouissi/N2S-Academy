using System;
using System.Linq;


namespace LMSTUDY.Views
{
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private void EyeIcon_Tapped(object sender, EventArgs e)
        {
            ConfirmPwdEntry.IsPassword = !ConfirmPwdEntry.IsPassword;
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

        private void PwdEntry_Unfocused(object sender, FocusEventArgs e)
        {
            string password = PwdEntry.Text;
            bool isStrong = IsPasswordStrong(password);
            bool isMedium = IsPasswordMedium(password);

            PasswordWeak.IsVisible = !isStrong && !isMedium;
            PasswordMedium.IsVisible = isMedium && !isStrong;
            PasswordStrong.IsVisible = isStrong;

            PasswordWeak.Text = "Mot de passe faible \n- Au moins 8 caractères \n- Une combinaison de lettres majuscules, minuscules, chiffres et symboles";
            PasswordStrong.Text = "Mot de passe fort";
        }
        private bool IsPasswordStrong(string password)
        {
            return password.Length >= 12 && ContainsUppercase(password) && ContainsLowercase(password) && ContainsNumber(password) && ContainsSymbol(password);
        }

        private bool IsPasswordMedium(string password)
        {
            return password.Length >= 8 && ContainsUppercase(password) && ContainsLowercase(password) && ContainsNumber(password) && ContainsSymbol(password);
        }

        private bool ContainsUppercase(string text)
        {
            return text.Any(char.IsUpper);
        }

        private bool ContainsLowercase(string text)
        {
            return text.Any(char.IsLower);
        }

        private bool ContainsNumber(string text)
        {
            return text.Any(char.IsDigit);
        }

        private bool ContainsSymbol(string text)
        {
            return text.Any(c => !char.IsLetterOrDigit(c));
        }


        private void ConfirmPwdEntry_Unfocused(object sender, FocusEventArgs e)
        {
            string enteredPassword = ConfirmPwdEntry.Text;
            string originalPassword = PwdEntry.Text;

            if (enteredPassword == originalPassword)
            {
                DisplayPasswordMatchMessage(true);
                HidePasswordWrongMessage();
            }
            else
            {
                HidePasswordMatchMessage();
                DisplayPasswordWrongMessage();
            }
        }

        private void DisplayPasswordMatchMessage(bool match)
        {
            PasswordMatch.IsVisible = match;
        }

        private void DisplayPasswordWrongMessage()
        {
            PasswordWrong.IsVisible = true;
        }

        private void HidePasswordMatchMessage()
        {
            PasswordMatch.IsVisible = false;
        }

        private void HidePasswordWrongMessage()
        {
            PasswordWrong.IsVisible = false;
        }


        private async void OnLabelTapped(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new LoginPage());
        }

        private async void ToHomePage(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new HomePage());
        }
    }

}
