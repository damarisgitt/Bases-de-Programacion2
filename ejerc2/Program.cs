using System;

namespace ejerc2
{
    class Program
    {
        static void Main(string[] args)
        // HACER UN PROGRAMA PARA INGRESAR DOS NUMEROS DISTINTOS Y LUEGO SE MUESTRE POR 
        // PANTALLA EL MENOR DE ELLOS.


        {  int N1, N2;
    
            Console.WriteLine("ingrese un numero");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            N2 = int.Parse(Console.ReadLine());
             
             if(N1 > N2){
                 Console.WriteLine("el menor es " + N2);
                 } else {
                    Console.WriteLine("el menor es " + N1);
                 }
            
             
            Console.WriteLine("fin del programa");
                           
         }
     }
 }
