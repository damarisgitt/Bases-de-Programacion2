using System;

namespace ejerc3
{
    class Program
    {
        static void Main(string[] args)
        {  // hacer un programa para ingresar dos numeros y que luego emita por pantalla el mayor de ellos
           //  o un cartel aclaratorio, "son iguales", en el caso de que asi lo sean.

           int n1, n2;

           Console.WriteLine("ingrese un numero");
           n1 = int.Parse(Console.ReadLine());
           Console.WriteLine("ingrese otro numero");
           n2 = int.Parse(Console.ReadLine());

           if(n1 == n2){
            Console.WriteLine("son iguales");
           }
           else if(n1 > n2){
            Console.WriteLine("el mayor de ellos es " + n1);
           }
           else{Console.WriteLine("el mayor de ellos es " + n2);
           }
           
           Console.WriteLine("fin del programa");
    
        }    
    }
}