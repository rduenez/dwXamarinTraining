using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace xBountyHunter.Views
{
    public class AgregarFugitivoPage : ContentPage
    {
        private StackLayout verticalStackLayout;
        private StackLayout horizontalStackLayout;
        private Button bagregar;
        private Button bcancelar;
        private Entry enewname; 


        public AgregarFugitivoPage()
        {
            verticalStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            horizontalStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center
            };

            bagregar = new Button { Text = "Agregar", BorderColor = Color.Black, BorderWidth = 1 };
            bcancelar = new Button { Text = "Cancelar", BorderColor = Color.Black, BorderWidth = 1 };

            enewname = new Entry { TextColor = Color.Black, BackgroundColor = Color.FromHex("#d3d3d3"), 
                HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.Center };

            verticalStackLayout.Children.Add(enewname);
            verticalStackLayout.Children.Add(horizontalStackLayout);

            horizontalStackLayout.Children.Add(bagregar);
            horizontalStackLayout.Children.Add(bcancelar);

            bagregar.Clicked += bagregar_Clicked;
            bcancelar.Clicked += bcancelar_Clicked;

            Content = verticalStackLayout;
        }

        private async void bcancelar_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<Page>(this, "Update");
            await Navigation.PopAsync();
        }

        private async void bagregar_Clicked(object sender, EventArgs e)
        {
            Extras.DataBaseManager db = new Extras.DataBaseManager();
            Models.mFugitivos nuevo_fugitivo = new Models.mFugitivos();

            nuevo_fugitivo.Name = enewname.Text;
            nuevo_fugitivo.Capturado = false;

            int result = db.insertItem(nuevo_fugitivo);

            if(result == 1)
            {
                await DisplayAlert("Agregado", "Se ha agregado el fugitivo", "Aceptar");
                MessagingCenter.Send<Page>(this, "Update");
                await Navigation.PopAsync();
            }

            db.closeConnection();
        }
    }
}
