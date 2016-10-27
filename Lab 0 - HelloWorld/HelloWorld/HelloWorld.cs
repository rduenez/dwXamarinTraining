using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWorld
{
    public class HelloWorldApp : Application
    {
        public HelloWorldApp()
        {
            this.MainPage = new HelloPage();
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
