using Xamarin.Forms;
using XFViews.Pages;

namespace XFViews
{
    public class App : Application
    {
        public App()
        {
            //MainPage = new ActivityIndicatorAndButtonPage();
            //MainPage = new SliderEntryLabelBindingsPage();
            MainPage = new PopUpsPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}