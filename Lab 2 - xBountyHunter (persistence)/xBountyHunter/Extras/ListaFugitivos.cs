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
        private DataBaseManager db = new DataBaseManager();

        public ListaFugitivos()
        {
            
        }

        public List<Models.mFugitivos> getFugitivos()
        {
            ocFugitivos = db.selectNotCaptured();
            return ocFugitivos;
        }

        public List<Models.mFugitivos> getCapturados()
        {
            ocFugitivos = db.selectCaptured();
            return ocFugitivos;
        }
    }
}
