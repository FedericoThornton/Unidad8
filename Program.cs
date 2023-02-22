using System;

namespace Unidad8
{
    class Program
    {
        static void Main(string[] args)
        {

            int n; 
            
            Console.WriteLine ("Ingrese un nro:");
            n = int.Parse (Console.ReadLine());

            while (n != 0)
            {
                Console.WriteLine ("Ingrese otro nro:");
                n = int.Parse (Console.ReadLine());

            }

        }
    }
}
