using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LocalWebAPI.Services;
using LocalWebAPI.Views;
using Xamarin.Essentials;

namespace LocalWebAPI
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        public static string IPAddress = DeviceInfo.Platform == DevicePlatform.Android ? "10.0.2.2" : "localhost";
        public static string AzureBackendUrl = $"http://{IPAddress}:5000";
        public static bool UseMockDataStore = false;

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();

            MainPage = new MainPage();
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
