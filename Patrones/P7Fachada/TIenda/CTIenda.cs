using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSistemas
{
    class CTienda
    {
        private string nombre;
        private string direccion;
        const double iva = 0.22;
        private Dictionary<CProducto, int> inventario;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public CTienda(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.inventario = new Dictionary<CProducto, int>();
        }

        public void AjustarPrecios()
        {
            foreach (CProducto item in inventario.Keys)
            {
                if (item.Precio == 0)
                {
                    item.Precio = item.Valor + item.Valor * iva;
                }
            }
        }

        public int ConsultarProducto(CProducto producto)
        {
            if (inventario.ContainsKey(producto))
            {
                return inventario[producto];
            }
            return -1;
        }

        public string AddProducto(CProducto nuevo, int cantidad)
        {
            if (inventario.ContainsKey(nuevo))
            {
                inventario[nuevo] += cantidad;
                return "Se han actualizado las cantidades del producto " + nuevo.Nombre;
            }
            nuevo.Precio = nuevo.Valor + nuevo.Valor * iva;
            inventario.Add(nuevo, cantidad);
            return "Se ha agregado al inventario el producto " + nuevo.Nombre;
        }

        public string RetirarProducto(CProducto producto, int cantidad)
        {
            if (inventario.ContainsKey(producto))
            {
                if (inventario[producto] >= cantidad)
                {
                    inventario[producto] -= cantidad;
                    return "Se ha realizado la extraccion";
                }
                return "No hay suficientes productos";
            }
            return "No se encuentra ese producto en el almacen";
        }

        public string VenderProducto(CProducto producto, int cant, CCuenta cuenta, int clave)
        {
            if (ConsultarProducto(producto) >= cant)
            {
                if (cuenta.Extracto(clave, ((producto.Precio) * cant)))
                {
                    this.RetirarProducto(producto, cant);
                    return "Correcto";
                }
            }
            return "Incorrecto";
        }
        public bool ComprarProducto(CAlmacen vendedora, CProducto producto, int cant, CCuenta cuenta, int ping)
        {
            if (vendedora.VenderProducto(producto, cant, cuenta, ping))
            {
                this.AddProducto(producto, cant);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string productos = "";
            foreach (CProducto item in inventario.Keys)
            {
                productos += item.ToString() + ", disponibilidad " + inventario[item] + "\n";
            }
            return "Tienda " + nombre + " con dreccion " + direccion + "\n" + " productos: " + "\n" + productos;
        }
    }
}
