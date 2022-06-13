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
        private int  Capacidad;
        private int  Precio;
        private string Motor;
        private int Ruedas;
        private string Carroceria;
        private string Color;
        private bool Luces;
        private string Suspencion;
        private int Asiento;
        private int Espejos;

        public Vehiculos(string NombreVehiculo, string FuenteDeEnergia, int Capacidad, int Precio, string Motor, int Ruedas, string Carroceria, string Color, bool Luces, string Suspencion, int Asiento, int Espejos)
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
        public int getCapacidad()
        {
            return Capacidad;
        }
        public void setCapacidad(int Capacidad)
        {
            this.Capacidad = Capacidad;
        }
        public int getPrecio()
        {
            return Precio;
        }
        public void setPrecio(int Precio)
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
        public int getRuedas()
        {
            return Ruedas;  
        }
        public void setRuedas(int Ruedas)
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
        public bool getLuces()
        {
            return Luces;
        }
        public void setLuces(bool Luces)
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
        public int getAsiento()
        {
            return Asiento;
        }
        public void setAsiento(int Asiento)
        {
            this.Asiento = Asiento; 
        }
        public int getEspejos()
        {
            return Espejos;
        }
        public void setEspejos(int Espejos)
        {
            this.Espejos = Espejos; 
        }
    }

}
