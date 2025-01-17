using System;

namespace ejerc6
{
    class Program
    {
        static void Main(string[] args)
        {
            //una casa de videojugos otorga un descuento dependiendo del importe de la compra realizada
            // segun los siguientes valores:
            //si el importe es menor a 1000 no hay descuento
            //si el importe es 1000 o + pero menor a 5000 aplica 10%
            //si el importe es 5000 o + aplica 18%
            //hacer un programa para ingresar un importe de venta y que te devuelva el importe final
            //con el descuento que corresponda.

            float descu, compra, des;

              Console.WriteLine("Por favor, ingrese de cuanto a sido su compra");
            compra = float.Parse(Console.ReadLine());

            if(compra > 5000){
                  des= compra * 18 / 100;
                  descu = compra - des;
                 Console.WriteLine("EL TOTAL A PAGAR ES DE: " + descu);
            }else if(compra > 1000){
                  des = compra * 10 / 100;
                  descu = compra - des;
                  Console.WriteLine("EL TOTAL A PAGAR ES DE: " + descu);
            }else{ 
                   Console.WriteLine("EL TOTAL A PAGAR ES DE: " + compra);
            }




        }
    }
}