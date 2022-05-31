using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    internal class SubClaseTractoCamion : SubClaseCarga
    {
        private string Remolque;
        private string ValvulaDeAire;
        public SubClaseTractoCamion(string Remolque, string ValvulaDeAire)
        {
            this.Remolque = Remolque;
            this.ValvulaDeAire = ValvulaDeAire;
        }
        public string getRemolque()
        {
            return Remolque;
        }
        public void setRemolque(string Remolque)
        {
            this.Remolque= Remolque;
        }
        public string getValvulaDeAire()
        {
            return ValvulaDeAire;
        }
        public void setValvulaDeAire(string ValvulaDeAire)
        {
            this.ValvulaDeAire = ValvulaDeAire;
        }
    }
}
