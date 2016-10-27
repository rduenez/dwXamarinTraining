using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace xBountyHunter
{
    public class xBountyHunterApp : Application
    {
        public xBountyHunterApp()
        {
            MainPage = new NavigationPage(new Views.MainTabbedPage());
        }
    }
}
