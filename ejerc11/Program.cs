using System;

namespace ejerc11
{
    class Program
    {
        static void Main(string[] args)
        { 
            // hacer un programa para ingresar 4 numeros, y luego mostrar por pantalla cuales 
            //son mayores a 100.

            int n1, n2, n3, n4, Co;

            Co = 0;

            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            n4 = int.Parse(Console.ReadLine());

            if(n1 > 100){
                Co++;
            }
            if(n2 > 100){
                Co++;
            }
            if(n3 > 100){
                Co++;
            }
            if(n4 > 100){
                Co++;
            }

            Console.WriteLine( "de los 4 numeros " + Co + " son mayores a 100");





        }
            
    }
}
