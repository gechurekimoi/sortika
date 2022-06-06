using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sortika
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDg3MjI3QDMxMzkyZTMyMmUzMEdKcTBINUEwaTlyT1pQT1ZEOGdhc1NCbTAyN0NsbjBhRk1zWkRYaE1LUzA9");


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
