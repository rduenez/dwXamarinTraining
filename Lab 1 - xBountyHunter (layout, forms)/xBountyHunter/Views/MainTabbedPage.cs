using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xBountyHunter.Views
{
    class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            ToolbarItem btnAgregar = new ToolbarItem("Agregar","",btnAgregar_onClick);
            ToolbarItems.Add(btnAgregar);
            this.Title = "X Bounty Hunter";
            if(Device.OS == TargetPlatform.iOS)
            {
                this.Padding = new Thickness(0, 20, 0, 0);
            }
            this.Children.Add(new FugitivosPage());
            this.Children.Add(new CapturadosPage());
            this.Children.Add(new AcercaDePage());


        }

        public void btnAgregar_onClick()
        {
            Navigation.PushAsync(new Views.AgregarFugitivoPage());
        }
    }
}
