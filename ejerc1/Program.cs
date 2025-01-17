using System;

namespace ejerc1
{
    class Program
  {
        static void Main(string[] args)

    {
       //1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio 
       //si “Es mayor a 10” o “No es mayor a 10”


        int N1;
        Console.WriteLine("ingrese un numero");
        N1 = int.Parse(Console.ReadLine());
        if (N1 > 10){
          Console.WriteLine("es mayor a 10");
        }
        else {
          Console.WriteLine("es menor a 10");
        }
        Console.WriteLine("fin del programa");


        


         
      

        
        
                    
            
            



      } 
      
    }

}
