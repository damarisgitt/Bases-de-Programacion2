using System;

namespace ejerc12
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa para ingresar un valor que estara expresado en minutos. 
            //si los minutos superan los 60 pasar el valor a horas, de lo contrario dejarlo en minutos
            //mostrar el resultado en pantalla aclarando si se muestra minutos u horas.

            int n1, h;

            Console.WriteLine("INGRESE MINUTOS");
            n1 = int.Parse(Console.ReadLine());

            if(n1 > 60){
                h = n1 / 60;
                Console.WriteLine("las horas son: " + h);
            }else {
                Console.WriteLine("los  minutos son: " + n1);
            }
        }
    }
}
