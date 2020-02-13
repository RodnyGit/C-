using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Flyweight
{
    class CAuto : IAuto
    {
        private string modelo;
        private string marca;
        private double costo;
        private double largo;
        private double ancho;
        private double peso;
        private double consumoPorKm;

        public CAuto(string modelo, string marca, double costo, double largo, double ancho, double peso, double consumoPorKm)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.costo = costo;
            this.largo = largo;
            this.ancho = ancho;
            this.peso = peso;
            this.consumoPorKm = consumoPorKm;
        }

        public string Modelo { get => modelo; }
        public string Marca { get => marca; }
        public double Costo { get => costo; }
        public double Largo { get => largo; }
        public double Ancho { get => ancho; }
        public double Peso { get => peso; }
        public double ConsumoPorKm { get => consumoPorKm; }

        public bool Economico()
        {
            if ((Liviano() && (KmPorLitro() > 27)) || (!Liviano() && (KmPorLitro() > 15)))
                return true;
            return false;
        }

        public double KmPorLitro()
        {
            return 1 / consumoPorKm;
        }

        public bool Liviano()
        {
            //formula peso/(largo+ancho)/2
            //limite, 350k por metro cuadrado
            double medida = this.peso / (this.largo + this.ancho) / 2;
            if (medida < 350)            
                return true;            
            return false;
        }

        public double Precio()
        {
            const double iva = 0.20;
            if (Economico())
                return costo + ((costo * iva) * 1.5);
            return costo + (costo * iva);
        }
    }
}
