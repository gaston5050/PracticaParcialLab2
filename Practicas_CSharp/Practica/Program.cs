using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] vectr = new int [3];
            vectr[0] = 1;
            vectr[1] = 2;
            vectr[2] = 8;

              for(int i = 0; i<3; i++){

                 Console.WriteLine(vectr[i]);

              }
        



          /*
          int num =1, cont =0, acum =0;

          while(num>0){
          
              while( num!=0){
                  Console.WriteLine("ingrese num");
                  num = int.Parse(Console.ReadLine());
                  acum += num; 

                  cont++;


              }
              cont = cont -1;
              acum = acum /cont;
              Console.WriteLine($"El promedio es {acum}");

          }

          Console.WriteLine("Escriba un numero: ");
          num = int.Parse(Console.ReadLine());
          Console.WriteLine($"Este es el numero:  {num}");
          for(int i = 0 ; i< num; i++){
            if((num-i) % 2 == 0){
                Console.WriteLine($"{num-i}");
  */
            }
            
          }
        }
    
