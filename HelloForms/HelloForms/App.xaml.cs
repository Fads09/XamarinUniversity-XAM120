using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloForms
{
    public partial class App : Application
    {
        public App()
        {
            var btn = new Button
            {
                Text = "Click me!"
            };

            int count = 1;

            btn.Clicked += (sender, args) =>
            {
                btn.Text = string.Format("Clicked {0} times.", count);
                count++;
            };

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        btn
                    }
            
                }
            };

            //InitializeComponent();

            //MainPage = new MainPage();
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
