using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LifeCycle
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "LifeCycle",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
                }
            };

            //MainPage = new NavigationPage(content);
            MainPage = content;
        }

        protected override void OnStart()
        {
            System.Diagnostics.Debug.WriteLine("OnStart");
        }

        protected override void OnSleep()
        {
            System.Diagnostics.Debug.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            System.Diagnostics.Debug.WriteLine("OnResume");
        }
    }
}
