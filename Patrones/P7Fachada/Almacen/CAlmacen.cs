using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSistemas
{
    class CAlmacen
    {
        private string nombre;
        private int id;

        private Dictionary<CProducto, int> inventario;

        public CAlmacen(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
            inventario = new Dictionary<CProducto, int>();
        }

        public string Nombre { get => nombre; }
        public int Id { get => id; }

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

        public bool VenderProducto(CProducto producto, int cant, CCuenta cuenta, int clave)
        {
            if (ConsultarProducto(producto) >= cant)
            {
                if (cuenta.Extracto(clave, ((producto.Valor) * cant)))
                {
                    this.RetirarProducto(producto, cant);
                    return true;
                }
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
            return "Almacen " + nombre + "\n" + " productos: " + "\n" + productos;
        }


    }
}
