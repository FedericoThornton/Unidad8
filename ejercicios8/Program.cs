using System;

namespace ejericios8
{
    class Program
    {
        static void Main(string[] args)
        
            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
         //   int precio, cantidadVendida, resultado;

          //  Console.WriteLine ("ingrese el precio del articulo: ");
          //  precio = int.Parse (Console.ReadLine());
         //   Console. WriteLine ("Ingrese cantidad vendida: ");
          //  cantidadVendida = int.Parse (Console.ReadLine());

            
            
         //   resultado = producto (precio, cantidadVendida);


         //   Console.WriteLine ("El monto total a pagar es: " + resultado);

//2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
//Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
        {
    //  int n, con = 0;

      //  for (int x = 0; x < 5; x++)
       // /{
         //   Console.WriteLine ("Ingrese un numero: ");
           // n = int.Parse (Console.ReadLine());
           // if (par(n) == true)
           // {
           //   con++;
           // }
       // }
        
      


  //  Console.WriteLine ("La cantidad de pares son: " + con);

//3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números.
// El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
      //    int n, con = 0, acu = 0, promedio;
         
     //    Console.WriteLine ("Ingrese un nro: ");
     //    n = int.Parse (Console.ReadLine());
         
    //      while (n != 0)
     //     {
     //       Console.WriteLine ("Ingrese otro nro: ");
    //        n = int.Parse (Console.ReadLine());

     //       if (primo (n) == true)
      //      {
     //         con++;
     //         acu += n;
     //       }
     //     }
//
      //   promedio = acu / con;

     ///    Console.WriteLine ("El promedio de los primos es: " + promedio);
//4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
//Que analice el número y escriba variable recibida por referencia con:

//a. 1 si el número es positivo.
//b. -1 si el número es negativo.
//c. 0 si el número es cero.

        int numero, estado = 9;
        Console.WriteLine ("Ingrese un nro: ");
        numero = int.Parse (Console.ReadLine());

        positivoNegativoCero (numero, ref estado);

        Console.WriteLine ("El estado del valor "+ numero "es: " + estado);

        }
        static void positivoNegativoCero (int a, ref int b)
        {
          if (a > 0)
          {
             b = 1;
          }
          else if (a < 0)
          {
             b = -1;
          }
          else
          {
             b = 0;
          }
        } 

         // static bool primo (int n1)
        //  {
        //    int con = 0;
       //     for (int x = 0; x <= n1; x++)
        //    {
       //       if (n1 % x == 0)
        //      {
         //       con++;
//
        //      if (con == 2)
        //      {
         //        return true;
          //    }
          //    else
          //    {
         //       return false;
          //    }
              

      //        }
              
              
       //       }

         //   static bool par (int n1) 
           // {
                                    
          //  if (n1 % 2 == 0)
           // {
             
          //  return true;
              
           //  }
           //  else
           //  {
           //     return false;
           //  }
           // }



       // static int producto (int n1, int n2)
       // {
        //    int r;
       //     r = n1 * n2;
       //     return r;
       // }
      //    }
    }
}
