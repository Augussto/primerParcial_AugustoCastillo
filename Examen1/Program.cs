using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantCamisas=0, precioInicial = 0, precioAPagar = 0 , porcentaje=0, descuento=0;
            String opciones;

            do
            {

                Console.WriteLine("- MENU -");
                Console.WriteLine("1. Añadir Camisa al Carro de Compras");
                Console.WriteLine("2. Eliminar Camisa del Carro de Compras");
                Console.WriteLine("3. Salir");

                opciones = Console.ReadLine();

                

                switch (opciones){

                    case "1":
                        cantCamisas += 1;
                        precioInicial += 1000;
                        ticket(cantCamisas, precioInicial, precioAPagar, porcentaje, descuento);
                        break;
                    case "2":
                        if (cantCamisas>0)
                        {
                            cantCamisas -= 1;
                            precioInicial -= 1000;
                            ticket(cantCamisas, precioInicial, precioAPagar, porcentaje, descuento);
                        }
                        else
                        {
                            Console.WriteLine("Usted no tiene Ninguna Camisa en el Carro");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Seguro que desea salir? S/N");
                        opciones = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opcion Ingresada Incorrecta, vuelva a intentarlo");
                        break;

                }

                Console.WriteLine("*Presione Enter para Continuar*");
                Console.ReadKey();
                Console.Clear();


            } while (opciones != "S");

            Console.ReadKey();


        }


        static public void ticket(int cantCamisas, int precioInicial, int precioAPagar, int porcentaje,int descuento)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Cantidad de Camisas en el Carro de Compras: "+cantCamisas);
            Console.WriteLine("Precio Unitario: $1000");
            Console.WriteLine("Precio Total sin Descuento: "+precioInicial);
            if(cantCamisas>=3 && cantCamisas <= 5)
            {
                porcentaje = 10;
            }else if (cantCamisas > 5)
            {
                porcentaje = 20;
            }
            else
            {
                porcentaje = 0;
            }
            Console.WriteLine("Tipo de Descuento Aplicado = % "+ porcentaje );
            descuento = (precioInicial * porcentaje) / 100;
            precioAPagar = precioInicial - descuento;
            Console.WriteLine("Precio Final con Descuento = "+precioAPagar);
            Console.WriteLine("------------------------------------------");

        }

    }
}
