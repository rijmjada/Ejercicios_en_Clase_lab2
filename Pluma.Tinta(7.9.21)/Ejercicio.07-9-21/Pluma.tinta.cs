using System;


namespace Ejercicio._07_9_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta miTinta1 = new Tinta(ConsoleColor.Red, ETipoTinta.Comun);
   
            Pluma pluma1 = new Pluma("Bic", miTinta1, 1);
          

            Console.WriteLine("Tinta 1\n" + Tinta.Mostrar(miTinta1));
          
            Console.WriteLine("");

            Console.WriteLine("Pluma 1" + pluma1);

            Console.WriteLine("");

            Console.WriteLine(pluma1 += miTinta1);


            Console.ReadKey();
        }
    }
}
