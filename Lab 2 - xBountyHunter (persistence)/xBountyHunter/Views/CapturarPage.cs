using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace xBountyHunter.Views
{
    public class CapturarPage : ContentPage
    {
        private Models.mFugitivos Fugitivo = new Models.mFugitivos();
        private Extras.DataBaseManager db = new Extras.DataBaseManager();
        private Label fugitivoSuelto;
        private Button bcapturar;
        private Button beliminar;
        private StackLayout verticalStackLayout;

        public CapturarPage(Models.mFugitivos fugitivo)
        {
            Fugitivo.Name = fugitivo.Name;
            Fugitivo.ID = fugitivo.ID;

            fugitivoSuelto = new Label { Text = "El fugitivo sigue suelto...", FontSize = 20, HorizontalOptions = LayoutOptions.Center };

            bcapturar = new Button { Text = "Capturar", WidthRequest = 200, BorderColor = Color.Black, 
                BorderWidth = 1 , HorizontalOptions = LayoutOptions.Center };
            beliminar = new Button { Text = "Eliminar", WidthRequest = 200, BorderColor = Color.Black, 
                BorderWidth = 1, HorizontalOptions = LayoutOptions.Center };

            verticalStackLayout = new StackLayout { Orientation = StackOrientation.Vertical , 
                VerticalOptions = LayoutOptions.CenterAndExpand , HorizontalOptions = LayoutOptions.FillAndExpand };

            bcapturar.Clicked += bcapturar_Clicked;
            beliminar.Clicked += beliminar_Clicked;

            this.Title = Fugitivo.Name;

            verticalStackLayout.Children.Add(fugitivoSuelto);
            verticalStackLayout.Children.Add(bcapturar);
            verticalStackLayout.Children.Add(beliminar);

            Content = verticalStackLayout;

        }

        private async void beliminar_Clicked(object sender, EventArgs e)
        {
            int result = db.deleteItem(Fugitivo.ID);

            if(result == 1)
                await DisplayAlert("Eliminado", "El fugitivo " + Fugitivo.Name + " ha sido eliminado", "Aceptar");
            else
                await DisplayAlert("Error", "Error al borrar al fugitivo", "Aceptar");

            db.closeConnection();
            MessagingCenter.Send<Page>(this, "Update");
            await Navigation.PopAsync();
        }

        private async void bcapturar_Clicked(object sender, EventArgs e)
        {
            Fugitivo.Capturado = true;
            int result = db.updateItem(Fugitivo);

            if (result == 1)
                await DisplayAlert("Capturado", "El fugitivo " + Fugitivo.Name + " ha sido capturado", "Aceptar");
            else
                await DisplayAlert("Error", "Error al capturar al fugitivo", "Aceptar");

            db.closeConnection();
            MessagingCenter.Send<Page>(this, "Update");
            await Navigation.PopAsync();
        }
    }
}
