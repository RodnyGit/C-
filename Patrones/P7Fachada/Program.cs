using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubSistemas;

namespace P7Fachada
{
    class Program
    {
        static void Main(string[] args)
        {
            CBanco santander = new CBanco("Sandander");

            //creando almacenes...
            CAlmacen lacteos = new CAlmacen("Lacteos", 01);
            CAlmacen carnes = new CAlmacen("Carnes", 02);
            CAlmacen ropa = new CAlmacen("Ropa", 03);
            CAlmacen frutas = new CAlmacen("Frutas", 04);
            CAlmacen aseo = new CAlmacen("Aseo", 05);
            CAlmacen electricos = new CAlmacen("Electricos", 05);

            //creando tiendas...
            CTienda devoto = new CTienda("TaTa", "Cerca");
            CTienda tata = new CTienda("TaTa", "Cerca");
            CTienda disco = new CTienda("TaTa", "Cerca");
            CTienda shoping = new CTienda("TaTa", "Cerca");
            CTienda zara = new CTienda("TaTa", "Cerca");

            //crear productos...
            CProducto leche = new CProducto("Leche", "leche01", 25, tiposProductos.Almiento);
            CProducto yogurt = new CProducto("Yogurt", "yogurt01", 45, tiposProductos.Almiento);
            CProducto zapato = new CProducto("Zapato", "zapato01", 700, tiposProductos.Ropa);
            CProducto carnePIcada = new CProducto("CarnePicada", "picada01", 200, tiposProductos.Almiento);
            CProducto jabon = new CProducto("Jabon", "Jabon01", 10, tiposProductos.Asaeo);
            CProducto ventilador = new CProducto("Ventilador", "ventilador01", 800, tiposProductos.Electrodomestico);
            CProducto melon = new CProducto("Melon", "Melon01", 100, tiposProductos.Almiento);
            CProducto mango = new CProducto("Mango", "Mango01", 150, tiposProductos.Almiento);
            CProducto pera = new CProducto("Pera", "Pera01", 50, tiposProductos.Almiento);


            CEntidades entidades = new CEntidades();


            //registrando banco en el sistema de envio...
            entidades.AddBanco(santander);

            //registrando almacenes en el sistema de envio...
            entidades.AddAlmacen(lacteos);
            entidades.AddAlmacen(carnes);
            entidades.AddAlmacen(ropa);
            entidades.AddAlmacen(frutas);
            entidades.AddAlmacen(aseo);
            entidades.AddAlmacen(electricos);

            //registrando tiendas en el sistema de envio...
            entidades.AddTienda(devoto);
            entidades.AddTienda(tata);
            entidades.AddTienda(disco);
            entidades.AddTienda(shoping);
            entidades.AddTienda(zara);

            //asignando producto a los almacenes...
            lacteos.AddProducto(leche, 2000);
            lacteos.AddProducto(yogurt, 2000);
            ropa.AddProducto(zapato, 500);
            carnes.AddProducto(carnePIcada, 50000);
            aseo.AddProducto(jabon, 5000);
            electricos.AddProducto(ventilador, 900);
            frutas.AddProducto(melon, 800);
            frutas.AddProducto(mango, 1000);
            frutas.AddProducto(pera, 1500);

            //creando usuarios
            CUsuario rodney = new CUsuario("Rodney", 860404);
            CUsuario uDevoto = new CUsuario("devoto", 010203);
            CUsuario uTata = new CUsuario("tata", 010204);
            CUsuario uDisco = new CUsuario("disco", 010205);
            CUsuario uShoping = new CUsuario("shoping", 010206);
            CUsuario uZara = new CUsuario("zara", 010207);

            //creando cuentas
            CCuenta cRodney = new CCuenta(123456, rodney, santander);
            CCuenta cDevoto = new CCuenta(111111, uDevoto, santander);
            CCuenta cTata = new CCuenta(222222, uTata, santander);
            CCuenta cDisco = new CCuenta(333333, uDisco, santander);
            CCuenta cShoping = new CCuenta(444444, uShoping, santander);
            CCuenta cZara = new CCuenta(555555, uZara, santander);

            //agregando saldo a las cuentas
            cRodney.Deposito(30000);    
            cDevoto.Deposito(100000);
            cDisco.Deposito(200000);
            cTata.Deposito(300000);
            cShoping.Deposito(400000);
            cZara.Deposito(500000);

            tata.ComprarProducto(lacteos, leche, 100, cTata, 123);

            tata.ComprarProducto(lacteos, yogurt, 100, cTata, 123);

            Console.WriteLine(frutas.ToString());

            Console.ReadKey();

        }
    }
}
