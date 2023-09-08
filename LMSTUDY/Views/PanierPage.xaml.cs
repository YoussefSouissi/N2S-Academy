using LMSTUDY.Models;

namespace LMSTUDY.Views;

public partial class PanierPage : ContentPage
{
	public PanierPage()
	{
		InitializeComponent();
        List<Course> subscribedCourses = GetSubscribedCourses();

        
        courseCollectionView.ItemsSource = subscribedCourses;
    }

    
    private List<Course> GetSubscribedCourses()
    {
        // Simulated data for demonstration
        return new List<Course>
        {
            new Course { CourseTitle = "Course 1", CourseImage = "angular.svg" },
            new Course { CourseTitle = "Course 2",CourseImage = "angular.svg" },
            new Course { CourseTitle = "Course 3",CourseImage = "angular.svg" }
        };
    }


    private async void ToContactPage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ContactPage());
    }
    private async void ToUserPage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new UserProfile());
    }
    private async void ToHomePage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new HomePage());
    }
}