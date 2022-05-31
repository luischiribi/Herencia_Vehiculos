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
        private string CapacidadPeso;
        private string FrenoDeAire;
        private string Cabina;

        public SubClaseCarga(string FuenteEnergiaDiesel, string Ejes, string CapacidadPeso, string FrenoDeAire)
        {
            this.FuenteEnergiaDiesel = FuenteEnergiaDiesel;
            this.Ejes = Ejes;
            this.CapacidadPeso = CapacidadPeso;
            this.FrenoDeAire = FrenoDeAire;
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
        public string getCapacidadPeso()
        {
            return CapacidadPeso;
        }
        public void setCapacidadPeso(string CapacidadPeso)
        {
            this.CapacidadPeso = CapacidadPeso;
        }
        public string getFrenoDeAire()
        {
            return FrenoDeAire;
        }
        public void setFrenoDeAire(string FrenoDeAire)
        {
            this.FrenoDeAire = FrenoDeAire;
        }
        public string getCabina()
        {
            return Cabina;
        }
        public void setCabina(string Cabina)
        {
            this.Cabina = Cabina;
        }
    }
}
