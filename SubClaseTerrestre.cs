using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    internal class SubClaseTerrestre : Vehiculos
    {
        private string Cilindraje;
        private string Bateria;
        private string Frenos;
        private string SistemaDeLubricacion;
        private string SistemaDeRefrigeracion;
        private string Rines;
        public SubClaseTerrestre(string Cilindraje, string Bateria, string Frenos, string SistemaDeLubricacion, string SistemaDeRefrigeracion, string Rines)
        {
            this.Cilindraje = Cilindraje;
            this.Bateria = Bateria;
            this.Frenos = Frenos;
            this.SistemaDeLubricacion = SistemaDeLubricacion;
            this.SistemaDeRefrigeracion = SistemaDeRefrigeracion;
            this.Rines = Rines;
        }
        public string getCilindraje()
        {
            return Cilindraje;
        }
        public void setCilindraje(string Cilindraje)
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
        public string getRines()
        {
            return Rines;
        }
        public void setRines(string Rines)
        {
            this.Rines = Rines;
        }

    }
}
