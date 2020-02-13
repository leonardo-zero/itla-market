using System;
using System.Collections.Generic;

namespace programa_de_colmado__2_
{
    class Program
    {
        public struct ventas
        {
            public string nombr1;
            public string produtos;
            public int precios;
            public int cantidad;
            public int total;

        }
     
        private static List<string> produt1 = new List<string>();
        private static List<int> preci1 = new List<int>();
        private static List<int> canti1 = new List<int>();

        private static List<string> client1 = new List<string>();
        public static List<ventas> vent1 = new List<ventas>();

        private static List<int> subto1 = new List<int>();
       

        static void Main(string[] args)
        {

            /*
               Esta tarea tiene una valor de 5 puntos , 
               debe realizar un pequeño sistema para un colmado ,
               donde el colmadero puede agregar los productos de su negocio ,
               los productos tienen nombre, precio y cantidad ,
               lo puede editar y borrar, también puede mantener los clientes (Solo el nombre) así que puede agregar cliente,
               editarlo y borrarlos.

               Por otra parte tiene la función de realizar ventas que le presentara una opción inicialmente de buscar al cliente introduciendo su nombre,
               una vez seleccionado el cliente, el sistema le permitirá buscar los productos disponible por su nombre, 
               cuando se selecciona un producto pregunta la cantidad que desea de ese producto y 
               si hay disponibilidad se agrega a la factura y se le pregunta si desea agregar mas productos 
               o finalizar la venta pero sino tiene la cantidad debe decirle que no tiene y mostrale la cantidad que tiene ,
               y preguntarle si desea introducir otra cantidad ,buscar otro producto o cancelar la venta ,
               en caso de que cancele la venta vuelve al menú principal.

               Una vez finalizada la venta debe mostrase por pantalla el nombre del cliente , 
               los productos que compro , con su cantidad y precio, 
               un subtotal que es el precio por la cantidad y un total que es la suma de todos los subtotales.

               Por ultimo el colmadero tiene una opción en el menú donde puede ver todas la ventas realizadas por clientes , 
               en esta opción busca al cliente por su nombre una vez seleccionado el cliente se muestra el listado de todas sus facturas.
               */
            Menu();

            Console.ReadKey();
        }
        private static void Menu()
        {
            while (true)
            {
                bool cierre = false;

                Console.Clear();
                Console.WriteLine("seleciones una de estas occiones ");
                Console.WriteLine(" 1: productos \n 2: clientes \n 3: ventas \n 4: facturacion \n 5: cierre del progrma ");
                int menu1 = Convert.ToInt32(Console.ReadLine());

                switch (menu1)
                {
                    case 1:
                        Productos();

                        break;
                    case 2:
                        Clientes();

                        break;
                    case 3:
                        venta1();

                        break;
                    case 4:
                        factura();

                        break;

                    case 5:
                        cierre = true;
                        break;


                }
                if (cierre)
                {
                    Console.WriteLine(" gracias por utilisar nuestro programa ");
                    break;
                }


                Console.ReadKey();

            }
           

        }
        private static void Productos()
        {
            while (true)
            {
                bool cierre1 = false;
                Console.Clear();
                Console.WriteLine("seleciones una de estas occiones \n ");
                Console.WriteLine(" <ingrese el producto con su respectivo precio y cantidad> ");
                Console.WriteLine(" 1: agregar producto \n 2: agregar presio del producto \n 3: agregar la cantidad \n 4: editar producto \n 5: borrar producto \n 6: ver productos  \n 7: volver a menu principal ");
                int menu2 = Convert.ToInt32(Console.ReadLine());

                switch (menu2)
                {
                    case 1:
                        productos();


                        break;

                    case 2:
                        precios();

                        break;
                    case 3:
                        cantidad();

                        break;
                    case 4:
                        editarproducto();

                        break;

                    case 5:
                        borrar();
                        
                        break;
                    case 6:
                        ver();

                        break;


                    case 7:
                        cierre1 = true;
                        break;

                }
                if (cierre1)
                {
                   
                    break;
                }
             


            }


        }
        private static void Clientes()
        {
            while (true)
            {
                bool cierre1 = false;
                Console.Clear();
                Console.WriteLine("seleciones una de estas occiones ");
                Console.WriteLine(" 1: agregar cliente \n 2: edictar cliente \n 3: ver clientes  \n 4: borrar clientes \n 5: volver a menu principal ");
                int menu3 = Convert.ToInt32(Console.ReadLine());

                switch (menu3)
                {
                    case 1:
                        clientes();
                        break;

                    case 2:
                        editcliente();

                        break;
                    case 3:
                        vercliente();

                        break;
                    case 4:
                        clienteborrar();


                        break;
                   
                    case 5:
                        cierre1 = true;
                        break;

                }
                if (cierre1)
                {

                    break;
                }



            }

        }

        static void productos()
        {
            Console.WriteLine("introducir el producto : ");
            string nom = Console.ReadLine();
            produt1.Add(nom);

            Console.ReadKey();
        }
        static void precios()
        {
            Console.WriteLine("introducir el precio del producto : ");
            int num1 = Int32.Parse(Console.ReadLine());
            preci1.Add(num1);

            Console.ReadKey();
        }
        static void cantidad()
        {
            Console.WriteLine("introducir la cantidad : ");
            int num2 = Int32.Parse(Console.ReadLine());
            canti1.Add(num2);

            Console.ReadKey();
        }




        static void editarproducto ()
        {
            productoedit();
            percioedit();
            cantidaddit();


        }

        static void productoedit()
        {
            foreach (var i in produt1)
            {
                Console.WriteLine("estos son todos los productos :");
                Console.WriteLine(i);
            }
            Console.WriteLine("seleciona el nombre del producto que quieres sustituir :");
            string nick = Console.ReadLine();

            produt1.Remove(nick);

            Console.WriteLine(" introducir el nuevo producto :");
            string nic = Console.ReadLine();

            produt1.Add(nic);

            foreach (var i in produt1)
            {
               
                Console.WriteLine("produsctos : {0}" ,i);
            }

            Console.ReadKey();
        }
        static void percioedit()
        {
            foreach (var i in preci1)
            {
                Console.WriteLine(" estos son todos los precios :");
                Console.WriteLine(i);
            }
            Console.WriteLine("seleciona el precio que quieres sustituir :");
            int nick = Int32.Parse(Console.ReadLine());

            preci1.Remove(nick);

            Console.WriteLine(" introducir el nuevo precio :");
            int nic = Int32.Parse(Console.ReadLine());

            preci1.Add(nic);

            foreach (var i in preci1)
            {

                Console.WriteLine("precios : {0}", i);
            }

            Console.ReadKey();
        }

         static void cantidaddit()
        {
            foreach (var i in canti1)
            {
                Console.WriteLine("estas son todas las cantidades :");
                Console.WriteLine(i);
            }
            Console.WriteLine("seleciona la cantidad que quieres sustituir :");
            int nick = Int32.Parse(Console.ReadLine());

            canti1.Remove(nick);

            Console.WriteLine(" introducir la nueva cantidad :");
            int nic = Int32.Parse(Console.ReadLine());

            canti1.Add(nic);

            foreach (var i in canti1)
            {

                Console.WriteLine("cantidad : {0}", i);
            }

            Console.ReadKey();
         }



        static void ver()
        {
           
            verprodutos();
            verprecios();
            vercantidad();

        }
        static void vercliente()
        {
            int e = 0;
            Console.WriteLine("estos son todos los clientes :");
            foreach (var i in client1)
            {
                e = e + 1;
                Console.WriteLine("{1}-cliente : {0}", i, e);

            }
            Console.ReadKey();
            
        }
        static void verprodutos()
        {
            int e = 0;
            Console.WriteLine("estos son todos los productos :");
            foreach (var i in produt1)
            {
                e = e + 1;
                Console.WriteLine("{1}-produsctos : {0}", i,e);
                
            }
            
        }
        static void verprecios()
        {
            int e = 0;
            Console.WriteLine("estos son todos los precios :");
            foreach (var i in preci1)
            {
                e = e + 1;
                Console.WriteLine("{1}-precios : {0}", i,e);
                
            }
            
        }
        static void vercantidad()
        {
            int e = 0;
            Console.WriteLine("estas son todas las cantidades :");
            foreach (var i in canti1)
            {
                e = e + 1;
                Console.WriteLine("{1}-cantidad : {0}", i, e);

            }
            Console.ReadKey();

        }


        static void borrar()
        {
            productoborrar();
            precioborrar();
            cantidadborrar();

        }

        static void productoborrar()
        {
            Console.WriteLine("estos son todos los productos :");
            foreach (var i in produt1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("seleciona el producto que quieres borrar :");
            string nick = Console.ReadLine();

            produt1.Remove(nick);


        }

        static void precioborrar()
        {
            Console.WriteLine("estos son todos los precios :");
            foreach (var i in preci1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("seleciona el precio que quieres borrar :");
            int nick = Int32.Parse(Console.ReadLine());

            preci1.Remove(nick);

        }

        static void cantidadborrar()
        {
            Console.WriteLine("estas son todas las cantidades :");
            foreach (var i in canti1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("seleciona el cantidad que quieres borrar :");
            int nick = Int32.Parse(Console.ReadLine());

            canti1.Remove(nick);


        }




        static void clientes()
        {
            Console.WriteLine(" introducir al cliente : ");
            string nom = Console.ReadLine();
            client1.Add(nom);

            Console.ReadKey();
        }

        static void editcliente()
        {
            int e = 0;
            Console.WriteLine("estos son todos los clientes :");
            foreach (var i in client1)
            {
                e = e + 1;
                Console.WriteLine(e +":"+i);
            }
            Console.WriteLine("seleciona colocando el nombre del cliente que quieres cambiar :");
            string nick = Console.ReadLine();

            client1.Remove(nick);

            Console.WriteLine(" introducir el nuevo cliente :");
            string nic = Console.ReadLine();

            client1.Add(nic);

            foreach (var i in client1)
            {

                Console.WriteLine("clientes : {0}", i);
            }

            Console.ReadKey();
        }

        static void clienteborrar()
        {
            int e = 0;
            Console.WriteLine("estos son todos los clientes :");
            foreach (var i in client1)
            {
                e = e + 1;
                Console.WriteLine(e + ":" + i);
            }
            Console.WriteLine("seleciona colocando el nombre del cliente que quieres borrar :");
            string nick = Console.ReadLine();

            client1.Remove(nick);


        }


        static void venta1()
        {
            while (true)
            {
                bool cierre1 = false;
                Console.Clear();
                Console.WriteLine("seleciones una de estas occiones ");
                Console.WriteLine(" 1: realisar venta \n 2: volver al menu principal \n ");
                int menu4 = Convert.ToInt32(Console.ReadLine());

                switch (menu4)
                {
                    case 1:
                        ventas1();

                        break;

                    case 2:
                        cierre1 = true;
                        break;

                }
                if (cierre1)
                {

                    break;
                }



            }
           

        }


      

        static void facturacion()
        {
            Console.WriteLine("estas son todas las facturas: ");
          
            foreach (ventas item in vent1)
            {
                Console.WriteLine("factura : " + (vent1.IndexOf(item) + 1));
                Console.WriteLine("Nombre del cliente: " + item.nombr1);
                Console.WriteLine("Nombre de producto: " + item.produtos);
                Console.WriteLine("Cantidad del producto: " + item.cantidad);
                Console.WriteLine("Precio del producto: " + item.precios);
                Console.WriteLine("Precio del total: " + item.total);
                Console.WriteLine("");
            }

        }
        static void contenido()
        {
            Console.WriteLine("introdusca el valor que quieres verificar");
            string i = Console.ReadLine();
               

            bool result = produt1.Contains(i);
            if (result == true)
            {
                Console.WriteLine("esta disponible el producto " + result);

            }
            else
            {
                Console.WriteLine("no hay producto disponible ");
            }
           
            Console.ReadKey();

        }



        static void ventas1()
        {
            bool cierre = false;
            while (true)
            {
                Console.Clear();
                vercliente();

                ventas vet = new ventas();

                int l1;
                Console.WriteLine("introdusca la posicion del nombre :");
                l1 = Int32.Parse(Console.ReadLine());

                string item2 = client1[l1 - 1];


                vet.nombr1 = item2;


                verprodutos();
                int w;
                Console.WriteLine("introdusca la posicion del producto");
                w = Int32.Parse(Console.ReadLine());

                string item1 = produt1[w - 1];



                vet.produtos = item1;

                verprecios();

                int i;
                Console.WriteLine("introdusca la posicion del producto");
                i = Int32.Parse(Console.ReadLine());

                int item = preci1[i - 1];

                vet.precios = item;

                Console.WriteLine(" <elija la cantidad que va a comprar sin exceder la cantidad de la lista>  ");
                vercantidad();
                //modificacion
                Console.WriteLine("intodusca la cantidad que vas a comprar : ");
                int num1 = Int32.Parse(Console.ReadLine());
                int num2 = canti1[i - 1];
                canti1.Remove(i - 1);
                int num3 = (num2 - num1);
                canti1[i - 1] = num3;

                vet.cantidad = num1;
                int Mult1 = item * num1;


                vet.total = Mult1;

                Console.WriteLine($" cliente: {vet.nombr1}, productos: {vet.produtos}, precio: {vet.precios}, cantidad: {vet.cantidad} , total : {vet.total} \n");

                Console.WriteLine(" estas seguro de hacer esta compra si es asi presione si o no");
                vent1.Add(vet);

                string nor1 = Console.ReadLine();
                if (nor1 == "si")
                {
                    subto1.Add(Mult1);
                    Console.WriteLine(" quieres hacer otra compra si o no ");
                    string nor = Console.ReadLine();
                    if (nor == "si")
                    {

                    }
                    else
                    {
                        Console.WriteLine("su venta ha sido realizada ");
                        cierre = true;

                        Console.ReadKey();

                    }
                    if (cierre)
                    {
                        break;
                    }

                }
                else
                {
                    vet.nombr1 = null;
                    vet.precios = 0;
                    vet.produtos = null;
                    vet.cantidad = 0;
                    vet.total = 0;
                    canti1[i - 1] = num2;
                    
                    Menu();
                }

                Console.ReadKey();

            }

           

        }
        static void totali1()
        {
            int e = 0;
            Console.WriteLine("este es el total de todas las ventas realisadas correctamente : ");
            int sum2 = 0;
            foreach (var i in subto1)
            {
                e = e + 1;
                Console.WriteLine("{0} : {1} " , e , i);
                sum2 = sum2 + i;

            }
          
            Console.WriteLine(" equivalente a {0}", sum2);
            Console.ReadKey(); 
        }
        static void factura()
        {
            while (true)
            {
                bool cierre1 = false;
                Console.Clear();
                Console.WriteLine("seleciones una de estas occiones ");
                Console.WriteLine(" 1: comprobar si hay productos \n 2: ver el total de todas las ventas \n 3: salir de factura  ");
                int menu5 = Convert.ToInt32(Console.ReadLine());

                switch (menu5)
                {
                    case 1:
                        contenido();


                        break;

                    case 2:
                        facturacion();
                        totali1();


                        break;

                    case 3:
                        cierre1 = true;
                        break;

                }
                if (cierre1)
                {

                    break;
                }



            }
            





        }
        



    }
}
