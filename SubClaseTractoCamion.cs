using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    internal class SubClaseTractoCamion : SubClaseCarga
    {
        private bool Remolque;
        private bool ValvulaDeAire;
        public SubClaseTractoCamion(bool Remolque, bool ValvulaDeAire)
        {
            this.Remolque = Remolque;
            this.ValvulaDeAire = ValvulaDeAire;
        }
        public bool getRemolque()
        {
            return Remolque;
        }
        public void setRemolque(bool Remolque)
        {
            this.Remolque= Remolque;
        }
        public bool getValvulaDeAire()
        {
            return ValvulaDeAire;
        }
        public void setValvulaDeAire(bool ValvulaDeAire)
        {
            this.ValvulaDeAire = ValvulaDeAire;
        }
    }
}
