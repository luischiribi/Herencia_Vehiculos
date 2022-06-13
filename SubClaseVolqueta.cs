using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    internal class SubClaseVolqueta  : SubClaseCarga
    {
        private bool Semiremolque;

        public SubClaseVolqueta(bool Semiremolque)
        {
            this.Semiremolque = Semiremolque;
        }
        public bool getSemiremolque()
        {
            return this.Semiremolque;
        }
        public void setSemiremolque(bool Semiremolque)
        {
            this.Semiremolque = Semiremolque;
        }
    }
}
