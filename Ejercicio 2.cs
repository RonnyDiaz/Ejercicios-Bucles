using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int aumento = 0;

            Console.Write("Inserte un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    aumento++;
                }
            }
           if (aumento > 2)
            {
                Console.WriteLine("No es un numero primo");
            }
            else
            {
                Console.WriteLine("Es un numero primo");
            }
        
        }
    }
}
