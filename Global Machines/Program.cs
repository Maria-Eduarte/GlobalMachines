using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Machines
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 10;
        static int contaFrituras = 0;
        static int contaResposteria = 0;
        static int contaRefGaseoso = 0;
        static int contaRefNatural = 0;
        static int contaConfiteria = 0;
        static int contanivel1= 0;
        static int contanivel2= 0;
        static int contanivel3= 0;
        static int contanivel4= 0;
        static int contanivel5 = 0;
        static string cliente = "";
        static string numeroTelefono = "";
        static double montoAPagar = 0;
        static int numero = 0;
        static int cantidad;
        static int calculo = 0;
        static double descuento = 0;
        static int pago = 0;
        static double vuelto = 0;
        static double impuestoVenta = 0;
       
        


        struct Producto
        {
            public int codigo_articulo;
            public string nombre_articulo;
            public string tipo ;
            public string Fecha_vencimiento;
            public string nombre_proveedor;
            public string posicion_estante;
            public int precio;

        };

        static Producto[] Productos;

        static void ingresoProductos()
        {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < Productos.Length)
                {
                    Console.WriteLine("*-* Global Machines *-*");
                    Console.WriteLine("Ingreso de Productos.             ");
                    Console.Write("Digite el codigo del Producto:                  ");
                    Productos[i].codigo_articulo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del Producto:    ");
                    Productos[i].nombre_articulo = Console.ReadLine();
                    Console.Write("Digite el tipo del Producto (Frituras, Reposteria, refrescos gaseosos, refrescos naturales,confiteria):     ");
                    Productos[i].tipo = Console.ReadLine();
                    Console.Write("Digite la fecha de Vencimiento del producto:    ");
                    Productos[i].Fecha_vencimiento = Console.ReadLine();
                    Console.Write("Digite el proveedor del Producto:    ");
                    Productos[i].nombre_proveedor = Console.ReadLine();
                    Console.Write("Digite la posicion del Producto (Nivel 1, Nivel 2, Nivel 3, Nivel 4, Nivel 5):     ");
                    Productos[i].posicion_estante = Console.ReadLine();
                    Console.Write("Digite el precio del Producto:    ");
                    Productos[i].precio = int.Parse(Console.ReadLine());

                    if (Productos[i].tipo == "Frituras" || Productos[i].tipo == "frituras")
                    {
                        contaFrituras = contaFrituras + 1;
                    }
                    else if (Productos[i].tipo == "Reposteria" || Productos[i].tipo == "reposteria")
                    {
                        contaResposteria = contaResposteria + 1;
                    }
                    else if (Productos[i].tipo == "refrescos gaseosos" || Productos[i].tipo == "Refrescos gaseosos")
                    {
                        contaRefGaseoso = contaRefGaseoso + 1;
                    }
                    else if (Productos[i].tipo == "refrescos naturales" || Productos[i].tipo == "Refrescos naturales")
                    {
                        contaRefNatural = contaRefNatural + 1;
                    }
                    else if (Productos[i].tipo == "confiteria" || Productos[i].tipo == "Confiteria")
                    {
                        contaConfiteria = contaConfiteria + 1;
                    }
                    else
                    {
                        Console.WriteLine("Verifique el tipo, solo pueden ser los mencionados anteriormente");
                    }

                    if (Productos[i].posicion_estante == "Nivel 1" || Productos[i].posicion_estante == "nivel 1")
                    {
                        contanivel1 = contanivel1 + 1;
                    }
                    else if (Productos[i].posicion_estante == "Nivel 2" || Productos[i].posicion_estante == "nivel 2")
                    {
                        contanivel2 = contanivel2 + 1;
                    }
                    else if (Productos[i].posicion_estante == "Nivel 3" || Productos[i].posicion_estante == "nivel 3")
                    {
                        contanivel3 = contanivel3 + 1;
                    }
                    else if (Productos[i].posicion_estante == "Nivel 4" || Productos[i].posicion_estante == "nivel 4")
                    {
                        contanivel4 = contanivel4 + 1;
                    }
                    else if (Productos[i].posicion_estante == "Nivel 5" || Productos[i].posicion_estante == "nivel 5")
                    {
                        contanivel5 = contanivel5 + 1;
                    }
                    else
                    {
                        Console.WriteLine("Verifique la posicion del producto de acuerdo a las indicadas");
                    }
                    Console.WriteLine("Desea agregar otro producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de productos esta lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }

        static void modificacionProductos()
        {
            int codigo_articulo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.WriteLine("*-* Global Machines *-*");
                Console.WriteLine("Modificacion de Productos.             ");
                Console.WriteLine("Digite el codigo del producto a modificar");
                codigo_articulo = int.Parse(Console.ReadLine());
                for (i = 0; i < Productos.Length; i++)
                {
                    if (codigo_articulo == Productos[i].codigo_articulo)
                    {
                        reg = i + 1;
                        Console.Write("Digite el nombre del Producto:    ");
                        Productos[i].nombre_articulo = Console.ReadLine();
                        Console.Write("Digite el tipo del Producto (Frituras, Reposteria, refrescos gaseosos, refrescos naturales,confiteria):     ");
                        Productos[i].tipo = Console.ReadLine();
                        Console.Write("Digite la fecha de Vencimiento del producto:    ");
                        Productos[i].Fecha_vencimiento = Console.ReadLine();
                        Console.Write("Digite el proveedor del Producto:    ");
                        Productos[i].nombre_proveedor = Console.ReadLine();
                        Console.Write("Digite la posicion del Producto (Nivel 1, Nivel 2, Nivel 3, Nivel 4, Nivel 5):     ");
                        Productos[i].posicion_estante = Console.ReadLine();
                        Console.Write("Digite el precio del Producto:    ");
                        Productos[i].precio = int.Parse(Console.ReadLine());
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                else
                {
                    Console.WriteLine("Desea modificar otro producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                }
            }
        }

        static void EliminarProductos()
        {
            int codigo_articulo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("Cual producto desea eliminar.           ");
                Console.WriteLine("Digite el codigo del producto a eliminar");
                codigo_articulo = int.Parse(Console.ReadLine());
                for (i = 0; i < Productos.Length; i++)
                {
                    if (codigo_articulo == Productos[i].codigo_articulo)
                    {
                        reg = i + 1;
                        Productos[i].codigo_articulo = 0;
                        Productos[i].nombre_articulo = "";
                        Productos[i].tipo = "";
                        Productos[i].Fecha_vencimiento = "";
                        Productos[i].nombre_proveedor = "";
                        Productos[i].posicion_estante = "";
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese codigo");
                    found = false;
                }
                Console.WriteLine("Producto eliminado");
                Console.WriteLine("Desea eliminar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void busquedaProductos()
        {
            int codigo_articulo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("Búsquedad de productos.           ");
                Console.WriteLine("Digite el codigo del producto a buscar");
                codigo_articulo = int.Parse(Console.ReadLine());
                for (i = 0; i < Productos.Length; i++)
                {
                    if (codigo_articulo == Productos[i].codigo_articulo)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Codigo del Articulo:       " + Productos[i].codigo_articulo);
                        Console.WriteLine("Nombre del Articulo:   " + Productos[i].nombre_articulo);
                        Console.WriteLine("Tipo:     " + Productos[i].tipo);
                        Console.WriteLine("Fecha:   " + Productos[i].Fecha_vencimiento);
                        Console.WriteLine("Nombre del Proveedor:   " + Productos[i].nombre_proveedor);
                        Console.WriteLine("Posicion del Estante:   " + Productos[i].posicion_estante);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese codigo");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void listaProductos()
        {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("*-* Global Machines *-*");
            Console.WriteLine("=================================");
            Console.WriteLine("Listado Productos");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Reg   Codigo   Nombre       Tipo   Vencimiento     Proveedor     Posicion     Precio");
            for (i = 0; i < Productos.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine(reg  + Productos[i].codigo_articulo + "        " +
                    Productos[i].nombre_articulo + "       " + Productos[i].tipo +
                    "      " + Productos[i].Fecha_vencimiento + "      " + Productos[i].nombre_proveedor +
                    "      " + Productos[i].posicion_estante + "      " + Productos[i].precio  );
            }
            Console.WriteLine("=================================");
            Console.ReadKey();
        }

        static void InventarioProductos()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("*-* Global Machines *-*");
            Console.WriteLine("=================================");
            Console.WriteLine("Informe de Inventario");
            Console.WriteLine("=================================");
            Console.WriteLine("Clasificacion    ||   Cantidad");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Frituras :          " + "|| " + contaFrituras);
            Console.WriteLine("Reposteria :         " + "|| " + contaResposteria);
            Console.WriteLine("Refrescos Gaseosos : " + "|| " + contaRefGaseoso);
            Console.WriteLine("Refrescos Naturales :" + "|| " + contaRefNatural);
            Console.WriteLine("Confiteria : "         + "|| " + contaConfiteria);
            Console.WriteLine("Nivel          ||         Cantidad");
            Console.WriteLine("Nivel 1:   " + "||  " + contanivel1);
            Console.WriteLine("Nivel 2:   " + "||  " + contanivel2);
            Console.WriteLine("Nivel 3:   " + "||  " + contanivel3);
            Console.WriteLine("Nivel 4:   " + "||  " + contanivel4);
            Console.WriteLine("Nivel 5:   " + "||  " + contanivel5);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("=================================");
            Console.ReadKey();
        }

        static void VentaProducos()
        {
            int codigo_articulo = 0;
            int precio = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("*-* Global Machines *-*");
            Console.WriteLine("====Seleccion de Productos====");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Codigo   Nombre       Precio");
            for (i = 0; i < Productos.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine(Productos[i].codigo_articulo + "        "  +
                    Productos[i].nombre_articulo + "       " + Productos[i].precio);
            }
            Console.WriteLine("=================================");

            Console.Write("Digite su nombre    ");
            cliente = Console.ReadLine();

            Console.Write("Digite su numero de telefono     ");
            numeroTelefono = Console.ReadLine();


            while (r != 1)
            {
                Console.WriteLine("  ");
                Console.WriteLine("Venta de Productos.           ");
                Console.Write("Que Producto desea comprar, seleccione segun el codigo a su izquierda");
                codigo_articulo = int.Parse(Console.ReadLine());
                Console.Write("Cuantas unidades desea comprar?");
                cantidad = int.Parse(Console.ReadLine());
                for (i = 0; i < Productos.Length; i++)
                {
                    if (codigo_articulo == Productos[i].codigo_articulo)
                    {
                        calculo = cantidad * Productos[i].precio;
                        descuento = 0;
                        montoAPagar = calculo + impuestoVenta;
                        impuestoVenta = montoAPagar * 0.13;
                        Console.Write("El monto total a pagar es de " + montoAPagar);
                        Console.Write("Con cuanto desea cancelar?");
                        pago = int.Parse(Console.ReadLine());
                        vuelto = pago - montoAPagar;

                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine(" * -*Global Machines * -*");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Factura Proforma               N001");
                        Console.WriteLine("Cliente: " + cliente);
                        Console.WriteLine("Numero de Telefono: " + numeroTelefono);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Item-------------------------------" + Productos[i].nombre_articulo);
                        Console.WriteLine("Cantidad---------------------------" + cantidad);
                        Console.WriteLine("Precio---------------------------" + Productos[i].precio);
                        Console.WriteLine("Subtotal---------------------------" + calculo);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Total Orden--------------------" + calculo);
                        Console.WriteLine("Descuento---------------------" + descuento);
                        Console.WriteLine("Impuesto Venta----------------" + impuestoVenta);
                        Console.WriteLine("Impuesto Total----------------" + impuestoVenta);
                        Console.WriteLine("Precio Neto-------------------" + montoAPagar);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Monto Recibido-----------------" + pago);
                        Console.WriteLine("Monto Cambio-------------------" + vuelto);
                        Console.WriteLine("===================================");
                        Console.WriteLine("Gracias por su compra...");
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese codigo");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());

        }

        }


        static void Main(string[] args)
        {
            Productos = new Producto[size];

            do
            {
                Console.Clear();
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1. Ingreso de Productos.");
                Console.WriteLine("2. Modificación de Productos.");
                Console.WriteLine("3. Eliminacion de Productos.");
                Console.WriteLine("4. Búsquedad de Productos.");
                Console.WriteLine("5. Listado de Productos.");
                Console.WriteLine("6. Venta de Productos.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            ingresoProductos();
                            break;
                        }
                    case 2:
                        {
                            modificacionProductos();
                            break;
                        }
                    case 3:
                        {
                            EliminarProductos();
                            break;
                        }
                    case 4:
                        {
                            busquedaProductos();
                            break;
                        }
                    case 5:
                        {
                            listaProductos();

                            InventarioProductos();
                            break;
                        }
                    case 6:
                        {
                            VentaProducos();
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}

