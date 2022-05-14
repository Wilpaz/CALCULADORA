using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_M
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CALCULADORA";
            string resp;
            do
            {
                int valor1; //Aqui se almacenara el primer valor ingresado.
                int valor2; //Aqui se almacenara el segundo valor ingresado.
                int Resultado; //Aqui se almacenara el resultado de la operacion.

                //Aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu de seleccion.
                Console.WriteLine("Presione el numero o simbolo para realizar la operacion\n");
                Console.WriteLine("\t1. SUMA(+)\n");
                Console.WriteLine("\t2. RESTA(-)\n");
                Console.WriteLine("\t3. MULTIPLICAR(*)\n");
                Console.WriteLine("\t4. DIVIDIR\n");
                Console.Write(" Eliga Una Opcion: "); //Aqui es donde indicaremos que operacion vamos a realizar
                resp = Console.ReadLine();

                string eleccion = Convert.ToString(resp);
                //Aqui se agregaran los mensajes para poder ingresar los datos.
                Console.WriteLine("\nIngrese sus dos Números\n");
                Console.Write("Valor1: ");
                valor1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Valor2: ");
                valor2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (eleccion)
                {
                    case "1":
                        Console.WriteLine("El resultado de la suma es:");
                        Resultado = valor1 + valor2;
                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, Resultado);
                        break;
                    case "2":
                        Console.WriteLine("El resultado de la resta es:");
                        Resultado = valor1 - valor2;
                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, Resultado);
                        break;
                    case "3":
                        Console.WriteLine("El resultado de la multiplicacion es:");
                        Resultado = valor1 * valor2;
                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, Resultado);
                        break;
                    case "4":
                        Console.WriteLine("El resultado de la division es:");
                        Resultado = valor1 / valor2;
                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, Resultado);
                        break;
                }
                Console.Write("\n¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.
                resp = Console.ReadLine();
            }
            while (resp == "s" || resp == "s");
        }
    }
}
