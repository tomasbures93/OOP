using Interface___Temperatur.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___Temperatur.Models
{
    internal class Temperatur : ICelsius, IFahrenheit, IKelvin
    {
        private double _temperatur;

        public double Celsius
        {
            get { return _temperatur; }
            set { _temperatur = value; }
        }

        public double Fahrenheit
        {
            get { return (_temperatur * 9) / 5 + 32; }
            set { _temperatur = (value - 32) * 5 / 9 ; }
        }

        public double Kelvin
        {
            get { return _temperatur + 273.15; }
            set { _temperatur = value - 273.15;  }
        }

        public override string ToString()
        {
            return $"Celsius: {Celsius:F2}° | Kelvin: {Kelvin:F2} Kelvin | Fahrenheit: {Fahrenheit:F2}° ";
        }
    }
}
