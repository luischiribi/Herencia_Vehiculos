using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    internal class Vehiculos : Object
    {
        private string NombreVehiculo;
        private string FuenteDeEnergia;
        private string Capacidad;
        private string Precio;
        private string Motor;
        private string Ruedas;
        private string Carroceria;
        private string Color;
        private string Luces;
        private string Suspencion;
        private string Asiento;
        private string Espejos;

        public Vehiculos(string NombreVehiculo, string FuenteDeEnergia, string Capacidad, string Precio, string Motor, string Ruedas, string Carroceria, string Color, string Luces, string Suspencion, string Asiento, string Espejos)
        {
            this.NombreVehiculo = NombreVehiculo;
            this.FuenteDeEnergia = FuenteDeEnergia;
            this.Capacidad = Capacidad;
            this.Precio = Precio;
            this.Motor = Motor;
            this.Ruedas = Ruedas;
            this.Carroceria = Carroceria;
            this.Color = Color;
            this.Luces = Luces;
            this.Suspencion = Suspencion;
            this.Asiento = Asiento;
            this.Espejos = Espejos;
        }
        public string getNombreVehiculo()
        {
            return NombreVehiculo;
        }
        public void setNombreVehiculo(string NombreVehiculo)
        {
            this.NombreVehiculo = NombreVehiculo;
        }
        public string getFuenteDeEnergia()
        {
            return FuenteDeEnergia;
        }
        public void setFuenteDeEnergia(string FuenteDeEnergia)
        {
            this.FuenteDeEnergia= FuenteDeEnergia;
        }
        public string getCapacidad()
        {
            return Capacidad;
        }
        public void setCapacidad(string Capacidad)
        {
            this.Capacidad = Capacidad;
        }
        public string getPrecio()
        {
            return Precio;
        }
        public void setPrecio(string Precio)
        {
            this.Precio = Precio;
        }
        public string getMotor()
        {
            return Motor;
        }
        public void setMotor(string Motor)
        {
            this.Motor = Motor;
        }
        public string getRuedas()
        {
            return Ruedas;  
        }
        public void setRuedas(string Ruedas)
        {
            this.Ruedas = Ruedas;   
        }
        public string getCarroceria()
        {
            return Carroceria;
        }
        public void setCarroceria(string Carroceria)
        {
            this.Carroceria = Carroceria;   
        }
        public string getColor()
        {
            return Color;
        }
        public void setColor(string Color)
        {
            this.Color = Color;
        }
        public string getLuces()
        {
            return Luces;
        }
        public void setLuces(string Luces)
        {
            this.Luces = Luces;
        }
        public string getSuspencion()
        {
            return Suspencion;
        }
        public void setSuspencion(string Suspencion)
        {
            this.Suspencion = Suspencion;
        }
        public string getAsiento()
        {
            return Asiento;
        }
        public void setAsiento(string Asiento)
        {
            this.Asiento = Asiento; 
        }
        public string getEspejos()
        {
            return Espejos;
        }
        public void setEspejos(string Espejos)
        {
            this.Espejos = Espejos; 
        }
    }

}
