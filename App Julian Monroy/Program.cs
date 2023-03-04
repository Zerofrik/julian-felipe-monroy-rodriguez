using System;

namespace App_Julian_Monroy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("ingrese el valor 1 para sumar");
            string valor1 = Console.ReadLine();
            int valornumero1 = Int32.Parse(valor1);

            Console.WriteLine("ingrese el valor 2");
            string valor2 = Console.ReadLine();
            int valornumero2 = Int32.Parse(valor2);

            Console.WriteLine("ingrese el valor 3 para restar");
            string valor3 = Console.ReadLine();
            int valornumero3 = Int32.Parse(valor3);

            Console.WriteLine("ingrese el valor 4");
            string valor4 = Console.ReadLine();
            int valornumero4 = Int32.Parse(valor4);

            Console.WriteLine("ingrese el valor 5 para multiplicar");
            string valor5 = Console.ReadLine();
            int valornumero5 = Int32.Parse(valor5);

            Console.WriteLine("ingrese el valor 6");
            string valor6 = Console.ReadLine();
            int valornumero6 = Int32.Parse(valor6);

            Console.WriteLine("ingrese el valor 7 para dividir");
            string valor7 = Console.ReadLine();
            int valornumero7 = Int32.Parse(valor7);

            Console.WriteLine("ingrese el valor 8");
            string valor8 = Console.ReadLine();
            int valornumero8 = Int32.Parse(valor8);

            Console.Write("el resultado de la suma es ");
            Console.WriteLine(valornumero1 + valornumero2);
            Console.Write("el resultado de la resta es ");
            Console.WriteLine(valornumero3 - valornumero4);
            Console.Write("el resultado de la multiplicacion es ");
            Console.WriteLine(valornumero5 * valornumero6);
            Console.Write("el resultado de la division es ");
            Console.WriteLine(valornumero7 / valornumero8);
        }
    }
}
