using System;

namespace ejerc10
{
    class Program
    {
        static void Main(string[] args)
        {
            //hacer un programa para ingresar 4 numeros y luego mostrar cuales son mayores a 100.

            int n1, n2, n3, n4,

            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            n4 = int.Parse(Console.ReadLine());

            if(n1 > 100){
                Console.WriteLine("este numero " + n1 + " es mayor a 100 ");
            }
            if(n2 > 100){
                Console.WriteLine("este numero " + n2 + " es mayor a 100 ");
            }
            if(n3 > 100){
                Console.WriteLine("este numero " + n3 + " es mayor a 100 ");
            }
            if(n4 > 100){
                Console.WriteLine("este numero " + n4 + " es mayor a 100 ");
            }
             




           


            
        }

    }
}
