using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace xBountyHunter.Views
{
    public class FugitivosPage : ContentPage
    {
        private ListView list = new ListView();

        public FugitivosPage()
        {
            this.Title = "Fugitivos";
            Extras.ListaFugitivos listaFugitivos = new Extras.ListaFugitivos();
            list.ItemsSource = listaFugitivos.ocFugitivos;
            list.ItemTemplate = new DataTemplate(typeof(ListViewCell));
            list.ItemTapped += list_ItemTapped;
            this.Content = list;
        }

        void list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.mFugitivos fugitivo = (Models.mFugitivos)e.Item;
            Navigation.PushAsync(new Views.CapturarPage(fugitivo));
        }
    }
}
