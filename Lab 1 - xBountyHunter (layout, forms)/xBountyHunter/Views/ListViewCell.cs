using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace xBountyHunter.Views
{
    class ListViewCell : ViewCell
    {
        private StackLayout cellWrapper;
        private Label nameLabel;

        public ListViewCell()
        {
            cellWrapper = new StackLayout { Orientation = StackOrientation.Vertical };
            nameLabel = new Label { FontSize = 20, HorizontalOptions = LayoutOptions.StartAndExpand };

            nameLabel.SetBinding(Label.TextProperty, "Name");
            cellWrapper.Children.Add(nameLabel);

            this.View = cellWrapper;
        }
    }
}
