using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xBountyHunter.Extras
{
    class ListaFugitivos
    {
        public List<Models.mFugitivos> ocFugitivos;

        public ListaFugitivos()
        {
            ocFugitivos = new List<Models.mFugitivos>();

            ocFugitivos.Add(new Models.mFugitivos
            {
                Name = "Joaquin Guzman",
            });
            ocFugitivos.Add(new Models.mFugitivos
            {
                Name = "Ismael Zambaba",
            });
            ocFugitivos.Add(new Models.mFugitivos
            {
                Name = "Hector Beltran Leyva",
            });
            ocFugitivos.Add(new Models.mFugitivos
            {
                Name = "Vicente Carrillo Fuentes",
            });
            ocFugitivos.Add(new Models.mFugitivos
            {
                Name = "Fernando Sanchez Arellano",
            });
        }
    }
}
