using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace xBountyHunter.Views
{
    public partial class CapturadosPage : ContentPage
    {
        public CapturadosPage()
        {
            InitializeComponent();
            Extras.ListaFugitivos listaFugitivos = new Extras.ListaFugitivos();
            List<Models.mFugitivos> capturados = listaFugitivos.ocFugitivos;
            list.ItemsSource = capturados;
        }

        void list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.mFugitivos fugitivo = (Models.mFugitivos)e.Item;
            Navigation.PushAsync(new Views.DetallePage(fugitivo));
        }
    }
}
