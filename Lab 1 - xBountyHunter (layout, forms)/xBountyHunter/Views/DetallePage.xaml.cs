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
        
        public DetallePage(Models.mFugitivos fugitivo)
        {
            InitializeComponent();
            Fugitivo = fugitivo;
            Title = Fugitivo.Name;
        }
    }
}
