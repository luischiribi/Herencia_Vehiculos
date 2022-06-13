using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    internal class SubClaseTerrestre : Vehiculos
    {
        private int Cilindraje;
        private string Bateria;
        private string Frenos;
        private string SistemaDeLubricacion;
        private string SistemaDeRefrigeracion;
        private int Rines;
        public SubClaseTerrestre(int Cilindraje, string Bateria, string Frenos, string SistemaDeLubricacion, string SistemaDeRefrigeracion, int Rines)
        {
            this.Cilindraje = Cilindraje;
            this.Bateria = Bateria;
            this.Frenos = Frenos;
            this.SistemaDeLubricacion = SistemaDeLubricacion;
            this.SistemaDeRefrigeracion = SistemaDeRefrigeracion;
            this.Rines = Rines;
        }
        public int getCilindraje()
        {
            return Cilindraje;
        }
        public void setCilindraje(int Cilindraje)
        {
            this.Cilindraje = Cilindraje;
        }
        public string getBateria()
        {
            return Bateria;
        }
        public void setBsteria(string Bateria)
        {
            this.Bateria = Bateria;
        }
        public string getFrenos()
        {
            return Frenos;
        }
        public void setFrenos(string Frenos)
        {
            this.Frenos = Frenos;
        }
        public string getSistemaDeLubricacion()
        {
            return SistemaDeLubricacion;
        }
        public void setSistemaDeLubricacion(string SistemaDeLubricacion)
        {
            this.SistemaDeLubricacion = SistemaDeLubricacion;
        }
        public string getSistemaDeRefrigeracion()
        {
            return SistemaDeRefrigeracion;
        }
        public void setSistemaDeRefrigeracion(string SistemaDeRefrigeracion)
        {
            this.SistemaDeRefrigeracion = SistemaDeRefrigeracion;
        }
        public int getRines()
        {
            return Rines;
        }
        public void setRines(int Rines)
        {
            this.Rines = Rines;
        }

    }
}
