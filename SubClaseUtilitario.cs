using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    internal class SubClaseUtilitario : SubClaseTerrestre
    {
        private string Puertas;
        private bool Manual;

        public SubClaseUtilitario(string Puertas, bool Manual)
        {
            this.Puertas = Puertas;
            this.Manual = Manual;
        }
        public string getPuertas()
        {
            return Puertas;
        }
        public void setPuertas(string Puertas)
        {
            this.Puertas = Puertas;
        }
        public bool getManual()
        {
            return Manual;
        }
        public void setManual(bool Manual)
        {
            this.Manual = Manual;
        }
    }
}
