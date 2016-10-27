using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace xBountyHunter.Views
{
    public class AcercaDePage : ContentPage
    {
        private Label ldevelopedby;
        private Label ldevelopername;
        private Label lyear;
        private Label ltrainingsr;
        private Label lratingvalor;
        private Slider srating;
        private StackLayout verticalStackLayout;


        public AcercaDePage()
        {
            ldevelopedby = new Label { Text = "Desarrollado por", FontSize = 15, HorizontalTextAlignment = TextAlignment.Center };
            ldevelopername = new Label { Text = "Ronald Duenez", FontSize = 12, HorizontalTextAlignment = TextAlignment.Center };
            lyear = new Label { Text = "2016", FontSize = 8, HorizontalTextAlignment = TextAlignment.Center };
            ltrainingsr = new Label { Text = "D.W. Training S.C.", FontSize = 12, HorizontalTextAlignment = TextAlignment.Center };
            lratingvalor = new Label { FontSize = 20, HorizontalTextAlignment = TextAlignment.Center };
            srating = new Slider { Maximum = 5, Minimum = 0, Value = 0, HorizontalOptions = LayoutOptions.FillAndExpand };
            verticalStackLayout = new StackLayout { Orientation=StackOrientation.Vertical , HorizontalOptions=LayoutOptions.FillAndExpand };

            this.Title = "Acerca de";
            lratingvalor.Text = srating.Value.ToString();
            verticalStackLayout.Children.Add(ldevelopedby);
            verticalStackLayout.Children.Add(ldevelopername);
            verticalStackLayout.Children.Add(lyear);
            verticalStackLayout.Children.Add(ltrainingsr);
            verticalStackLayout.Children.Add(srating);
            verticalStackLayout.Children.Add(lratingvalor);

            srating.ValueChanged += (sender, args) =>
                {
                    double value = srating.Value;
                    value = Math.Round(value * 2) / 2;
                    lratingvalor.Text = value.ToString();
                };

            this.Content = verticalStackLayout;

        }
    }
}
