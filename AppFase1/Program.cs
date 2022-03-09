using System;

namespace AppFase1
{
    class Program
    {
        static String name;
        static int estrato;
        static int days;



        private static Boolean setName()
        {
            bool status = false;
            String nameLocal;
            Console.WriteLine("Ingrese por favor su nombre");
            nameLocal = Console.ReadLine();
            if (nameLocal.Equals(""))
            {
                Console.WriteLine("Debe ingresar un nombre valido\n");
                setName();
            }
            else
            {
                name = nameLocal;
                status = true;
            }


            return status;
        }

        private static Boolean setEstrato()
        {

            bool status = false;
            int estratoNumber = 0;
            Console.WriteLine("Ingrese el estrato en numeros");
            String estratoLocal = Console.ReadLine();
            if (estratoLocal.Equals(""))
            {

                Console.WriteLine("<<<<<<Precaucion: Debe ingresar un valor valido>>>>>>\n");
                setEstrato();
            }
            else
            {
                try
                {
                    estratoNumber = Int32.Parse(estratoLocal);
                    estrato = estratoNumber;

                }
                catch (Exception ex)
                {

                    Console.WriteLine("<<<<<<<Recuerde:El valor debe ser numerico por favor intente nuevamente, " +
                                        "el programa se finalizara>>>>>>\n");
                    Environment.Exit(0);
                }


                status = true;

            }

            

            return status;
        }

        private static Boolean setDays()
        {

            bool status = false;
            int stayDays = 0;
            Console.WriteLine("Ingrese los dias que se hospedara en el hotel");
            String daysLocal = Console.ReadLine();
            if (daysLocal.Equals(""))
            {

                Console.WriteLine("Debe ingresar un valor valido\n");
                setDays();
            }
            else
            {
                try
                {
                    stayDays = Int32.Parse(daysLocal);

                }
                catch (Exception ex)
                {

                    Console.WriteLine("<<<<<<<Recuerde:El valor debe ser numerico por favor," +
                        "el programa se finalizara>>>>>>\n");
                    Environment.Exit(0);
                    
                }
                
                days = stayDays;

            }
            


            return status;
        }

        private static String setPayment()
        {
            var rand = new Random();
            int factura = 10 * rand.Next();
            double descuento = 0;
            double valuePayment = 0;
            if ((estrato == 1) || (estrato == 2))
            {

                descuento = (((days * 90000) * 15) / 100);
                valuePayment = ((days * 90000) - descuento);
            }
            else
            {
                valuePayment = (days * 90000);
            }


            String message = "Factura de venta No. 000" + factura + "\nCliente: " + name + "\n"
                + "Total dias estadía:" + days + "\n" + "descuento por estrato entre 1 - 2: $" + descuento
                + "\n" + "Valor a cancelar: $" + valuePayment;

            return message;
        }

        private static void printTicket()
        {
            setName();
            setEstrato();
            setDays();
            Console.WriteLine(setPayment());
        }



        static void Main(string[] args)
        {
            printTicket();
        }
    }
}
