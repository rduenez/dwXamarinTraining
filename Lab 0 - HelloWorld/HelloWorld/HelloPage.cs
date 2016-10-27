using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    class HelloPage: ContentPage
    {
        public HelloPage()
        {
            this.Title = "Hola mundo cruzado";

            StackLayout stackLayout = new StackLayout { Orientation = StackOrientation.Vertical , VerticalOptions = LayoutOptions.CenterAndExpand };
            Label helloLabel = new Label { FontSize = 20 , HorizontalTextAlignment = TextAlignment.Center };
            helloLabel.Text = "Hola Mundo desde Xamarin Forms";

            if (Device.OS == TargetPlatform.Android)
                helloLabel.Text += " (para Android)";
            if (Device.OS == TargetPlatform.iOS)
                helloLabel.Text += " (para iOS)";

            stackLayout.Children.Add(helloLabel);
            Content = stackLayout;
        }
    }
}
