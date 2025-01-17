using System;

namespace ejerc9
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa para ingresar 5 numeros distintos y luego mostrar por pantalla el mayor
            // y el menor de ellos.

            int n1, n2, n3, n4, n5, mayor, menor;

            Console.WriteLine("ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el cuarto numero");
            n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el quinto numero");
            n5 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                mayor = n1;
                menor = n2;
            }else{
               mayor = n2;
               menor = n1;
            }
            if(n3 > mayor){
               mayor = n3;
            }if(n3 < menor){
               menor = n3;
            }
            if(n4 > mayor){
                mayor = n4;
            }if(n4 < menor){
                menor = n4;
            }
            if(n5 > mayor){
                mayor = n5;
            }if(n5 < menor){
                menor = n5;
            }

            Console.WriteLine("el mayor numero de los  5 es: " + mayor);
            Console.WriteLine("el menor de los 5 numeros es: " + menor);



        }
    }
}
