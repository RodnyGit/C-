using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSistemas
{
    class CEntidades
    {
        private List<CTienda> listaTiendas;
        private List<CAlmacen> listaAlmacenes;
        private List<CBanco> listaBancos;

        internal List<CTienda> ListaTiendas { get => listaTiendas; }
        internal List<CAlmacen> ListaAlmacenes { get => listaAlmacenes; }
        internal List<CBanco> ListaBancos { get => listaBancos; }

        public CEntidades()
        {
            this.listaTiendas = new List<CTienda>();
            this.listaAlmacenes = new List<CAlmacen>();
            this.listaBancos = new List<CBanco>();
        }

        public string AddBanco(CBanco banco)
        {
            foreach (CBanco item in listaBancos)
            {
                if (item == banco)
                {
                    return "Ya existe el banco " + banco.Nombre;
                }
            }
            listaBancos.Add(banco);
            return "Banco " + banco.Nombre + " agregado...";
        }

        public string AddAlmacen(CAlmacen almacen)
        {
            foreach (CAlmacen item in listaAlmacenes)
            {
                if (item == almacen)
                {
                    return "Ya existe el almacen " + almacen.Nombre;
                }
            }
            listaAlmacenes.Add(almacen);
            return "Almacen " + almacen.Nombre + " agregado...";
        }

        public string AddTienda(CTienda tienda)
        {
            foreach (CTienda item in listaTiendas)
            {
                if (item == tienda)
                {
                    return "Ya existe la tienda" + tienda.Nombre;
                }
            }
            listaTiendas.Add(tienda);
            return "Tienda" + tienda.Nombre + " agregado...";
        }
    }
}
