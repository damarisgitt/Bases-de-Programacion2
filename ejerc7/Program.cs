using System;

namespace ejerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa para ingresar cuatro numeros distintos y luego mostrar por pantalla el 
            // mayor de ellos.

             int n1, n2, n3, n4, mayor;
             
             Console.WriteLine("ingrese el primer numero");
             n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("ingrese el segundo numero");
             n2 = int.Parse(Console.ReadLine());
             Console.WriteLine("ingrese el tercer numero");
             n3 = int.Parse(Console.ReadLine());
             Console.WriteLine("ingrese el cuarto numero");
             n4 = int.Parse(Console.ReadLine());

            if(n1 > n2)
                mayor = n1;
             else 
                mayor = n2;

            if(n3 > mayor)
                mayor = n3; 

            if(n4 > mayor)
                mayor = n4;

                Console.WriteLine("El mayor de los cuatros es: " + mayor);




        }
    }
}
