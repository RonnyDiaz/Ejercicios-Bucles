using System;

namespace Recorrida_de_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
           for(int i = 1; i <= 100; i++)
            {
                if(i % 10 == 0)
                {
                    Console.WriteLine(i);
                    a++;
                }
            }
            Console.WriteLine("La cantidad de ceros recorridos es de {0} ceros", a);
        
        }
    }
}
