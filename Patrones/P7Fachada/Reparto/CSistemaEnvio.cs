using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSistemas
{
    class CSistemaEnvio
    {
        private List<CTienda> listaTiendas;
        private List<CAlmacen> listaAlmacenes;
        private List<CBanco> listaBancos;

        public CSistemaEnvio()
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
                    return "Ya existe el banco " + almacen.Nombre;
                }
            }
            listaAlmacenes.Add(almacen);
            return "Banco " + almacen.Nombre + " agregado...";
        }

        public string AddTienda(CTienda tienda)
        {
            foreach (CTienda item in listaTiendas)
            {
                if (item == tienda)
                {
                    return "Ya existe el banco " + tienda.Nombre;
                }
            }
            listaTiendas.Add(tienda);
            return "Banco " + tienda.Nombre + " agregado...";
        }
    }
}
