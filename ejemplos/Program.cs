using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {

          int n, conpar = 0, conimpar = 0; 
          int maxpar;

          Console.WriteLine ("Ingrese un nro:");
            n = int.Parse (Console.ReadLine());

            while (n != 0)
            {
                Console.WriteLine ("Ingrese otro nro:");
                n = int.Parse (Console.ReadLine());

                if (n % 2 == 0)
                {
                  if (conpar == 0)
                  {
                    maxpar = n;
                    conpar = 1;
                  }
                      else if (n > maxpar)
                  {
                        maxpar = n;
                        conpar++;
                  }
                      else
                  {
                        conimpar++;
                  }
                }
           
                

            Console.WriteLine ("El mayor de los nros pares es: " + maxpar);
            Console.WriteLine ("La cantidad de nros impares es: " + conimpar);

            }

            // FUCIONES es un bloque de codigo 
            // partes de la funcion
            // una cabecera
            // 1. tipo de funcion/ tipo de dato
            // 2. nombre
            // 3. parametros (opcional): datos que le das a la funcion para que trabaje
            // un cuerpo
            // 1. definicion o logica de la funcion
             // 2. retorno/ return  de valor o resultado (opcional)
           //  int n = devolverUno();
         //    Console.WriteLine ("Fin del programa " + n);

     //       int n1, n2, resultado;

       //     pedirDatos (ref n1, ref n2);
            // logics
          //  resultado = n1 + n2;
      //     resultado = sumar (ref n1, n2);
            // fin logica
      //      Console.WriteLine ("El resultado es: " + resultado);






            // SCOPE
     //   }

       // static void sumar (ref int n1, int n2)
      //  {
      //      int r;
      //      r = a + b;
      //      return r;
      //  }
      //    static int pedirDatos (ref int j, ref int h)
      //    {
      //      Console.WriteLine ("ingrese un numero");
      //      j = int.Parse (Console.ReadLine());
      //      Console.WriteLine ("Ingrese otro");
      //      h = int.Parse (Console.ReadLine());
          }
            
      //  static int devolverUno() {
        //    int nro = 1;
       //     return nro;
        
    }
}
