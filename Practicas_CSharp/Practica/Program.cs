using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
          int num;

          Console.WriteLine("Escriba un numero: ");
          num = int.Parse(Console.ReadLine());
          Console.WriteLine($"Este es el numero:  {num}");
          for(int i = 0 ; i< num; i++){
            if((num-i) % 2 == 0){
                Console.WriteLine($"{num-i}");
            }
            
          }
        }
    }
}
