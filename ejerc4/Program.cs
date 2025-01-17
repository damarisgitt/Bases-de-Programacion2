using System;

namespace ejerc4
{
    class Program
    {
        static void Main(string[] args)
        { // HACER UN PROGRAMA PARA INGRESAR UN NUMERO Y LUEGO SE EMITA UN CARTEL POR PANTALLA, "POSITIVO" 
          // SI EL NNUMERO ES MAYOR A CERO, "NEGATIVO" SI EL NUMERO ES MENOR A CERO, O "CERO", SI ES IGUAL A CERO.

            int n1;
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            if(n1 > 0){
            Console.WriteLine("positivo");
            }
            else if(n1 < 0){
            Console.WriteLine("negativo");
            }
            else {Console.WriteLine("CERO");
            }
         }
    }    
    
}
