using System;

namespace impuestador
{
    class Impuesto
    {
        static void Main(string[] args)
        {
            static void mensajeInicial()
            {

                Console.WriteLine("Impuestador 1.0\nIC 2022 ©\n"  );

            }



            mensajeInicial();
            calcularImpuestos();





            //}
            static void calcularImpuestos()
            {
                

                float subTotal;
                Console.WriteLine("Ingrese el costo de la compra en pesos argentinos o 0 para cerrar la aplicación");



                try
                {

                    subTotal = float.Parse(Console.ReadLine());
                    if (subTotal != 0)
                    {
                        float ganancia = subTotal * 0.45f;
                        float iva = subTotal * 0.21f;
                        float impuestoPais = subTotal * 0.08f;

                        float total = subTotal + ganancia + iva + impuestoPais;

                        Console.WriteLine($"Subtotal = {subTotal}\nImpuesto ganancia = {ganancia}\nIVA = {iva}\nImpuesto Pais = {impuestoPais}\n-------\nTotal = {total} ARS\n");
                        calcularImpuestos();
                    }
                }

                catch
                {
                    Console.WriteLine("Debe insertar un número");
                    calcularImpuestos();

                }
            }
        }
    }
}
  
     
  

            
        
   


