using System;

namespace ejerc8
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa para ingresar cuatro numeros distintos y luego mostrar por 
            //pantalla el menor de ellos.

            int n1, n2, n3, n4, menor;

            Console.WriteLine("hola buenas, ingrese el primer numero y le diremos cual es el menor");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el cuarto numero");
            n4 = int.Parse(Console.ReadLine());
            
            if(n1 < n2){
                menor = n1;
            }else 
                menor = n2;
            if(n3 < menor)  
                menor = n3;
            if(n4 < menor)
                menor = n4;
            
            Console.WriteLine("el menor de los cuatros numeros es: " + menor);

        }
    }
}
