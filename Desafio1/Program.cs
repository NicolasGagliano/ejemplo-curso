using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string l;
            //Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.

            Telefono t1 = new Telefono("MK1","Samsung");

            Telefono t2 = new Telefono("S50", "Nokia");

            Console.WriteLine("Ingrese el numero de telefono del T1:");
            t1.NumeroTelefonico = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de Operador del T1:");
            t1.CodigoOperador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de telefono del T2:");
            t2.NumeroTelefonico = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de Operadordel T1:");
            t2.CodigoOperador = int.Parse(Console.ReadLine());

            t1.Marca = "Nokia";

            Console.WriteLine("La informacion del primer telefono es: /n Marca: " + t1.Marca + " numero: " + t1.NumeroTelefonico);

            

          

            t1.Llamar("Smeagol");


            Console.WriteLine(t1.Llamar());

            Console.WriteLine(t1.Llamar("Smeagol"));


            
            Console.ReadKey();

        }
    }
}
