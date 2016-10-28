using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace xBountyHunter.Views
{
    public partial class DetallePage : ContentPage
    {
        private Models.mFugitivos Fugitivo = new Models.mFugitivos();
        private Extras.DataBaseManager db = new Extras.DataBaseManager();
        
        public DetallePage(Models.mFugitivos fugitivo)
        {
            InitializeComponent();
            Fugitivo = fugitivo;
            Title = Fugitivo.Name;
        }

        private async void beliminar_Clicked(object sender, EventArgs e)
        {
            int result = db.deleteItem(Fugitivo.ID);

            if (result == 1)
                await DisplayAlert("Eliminado", "El fugitivo " + Fugitivo.Name + " ha sido eliminado", "Aceptar");
            else
                await DisplayAlert("Error", "Error al borrar al fugitivo", "Aceptar");

            db.closeConnection();
            MessagingCenter.Send<Page>(this, "Update");
            await Navigation.PopAsync();

        }
    }
}
