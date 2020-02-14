using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSistemas
{
    class CProducto
    {
        private string nombre;
        private string id;
        private double valor;
        private double precio;
        private tiposProductos tipo;

        public CProducto(string nombre, string id, double valor, tiposProductos tipo)
        {
            this.nombre = nombre;
            this.id = id;
            this.valor = valor;
            this.precio = 0;            
            this.tipo = tipo;
        }

        public string Nombre { get => nombre; }
        public string Id { get => id; }
        public double Valor { get => valor; }
        public double Precio { get => precio; set => precio = value; }
        internal tiposProductos Tipo { get => tipo; }
    }
}
