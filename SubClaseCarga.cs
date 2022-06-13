using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    internal class SubClaseCarga  : SubClaseUtilitario
    {
        private string FuenteEnergiaDiesel;
        private string Ejes;
        private int CapacidadPeso;
        private bool FrenoDeAire;
        private bool Cabina;

        public SubClaseCarga(string FuenteEnergiaDiesel, string Ejes, int CapacidadPeso, bool FrenoDeAire, bool Cabina)
        {
            this.FuenteEnergiaDiesel = FuenteEnergiaDiesel;
            this.Ejes = Ejes;
            this.CapacidadPeso = CapacidadPeso;
            this.FrenoDeAire = FrenoDeAire;
            this.Cabina = Cabina;
        }
        public string getFuenteEnergiaDiesel()
        {
            return FuenteEnergiaDiesel;
        }
        public void setFuenteEnergiaDiesel(string FuenteEnergiaDiesel)
        {
            this.FuenteEnergiaDiesel = FuenteEnergiaDiesel;
        }
        public string getEjes()
        {
            return Ejes;
        }
        public void setEjes(string Ejes)
        {
            this.Ejes = Ejes;
        }
        public int getCapacidadPeso()
        {
            return CapacidadPeso;
        }
        public void setCapacidadPeso(int CapacidadPeso)
        {
            this.CapacidadPeso = CapacidadPeso;
        }
        public bool getFrenoDeAire()
        {
            return FrenoDeAire;
        }
        public void setFrenoDeAire(bool FrenoDeAire)
        {
            this.FrenoDeAire = FrenoDeAire;
        }
        public bool getCabina()
        {
            return Cabina;
        }
        public void setCabina(bool Cabina)
        {
            this.Cabina = Cabina;
        }
    }
}
