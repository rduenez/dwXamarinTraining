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
            MessagingCenter.Subscribe<Page>(this, "Update", messageCallBack);
            list.ItemsSource = listaFugitivos.getFugitivos();
            list.ItemTemplate = new DataTemplate(typeof(ListViewCell));
            list.ItemTapped += list_ItemTapped;
            this.Content = list;
        }

        void list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.mFugitivos fugitivo = (Models.mFugitivos)e.Item;
            Navigation.PushAsync(new Views.CapturarPage(fugitivo));
        }

        public void messageCallBack (Page obj)
        {
            Extras.ListaFugitivos listafugitivos = new Extras.ListaFugitivos();
            list.ItemsSource = listafugitivos.getFugitivos();
        }
    }
}
