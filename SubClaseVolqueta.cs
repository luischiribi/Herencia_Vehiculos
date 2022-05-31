using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    internal class SubClaseVolqueta  : SubClaseCarga
    {
        private string Semiremolque;

        public SubClaseVolqueta(string Semiremolque)
        {
            this.Semiremolque = Semiremolque;
        }
        public string getSemiremolque()
        {
            return this.Semiremolque;
        }
        public void setSemiremolque(string Semiremolque)
        {
            this.Semiremolque = Semiremolque;
        }
    }
}
