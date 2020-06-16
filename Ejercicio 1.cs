using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla = 7;
            int multiplicando = 0;
          
            while(multiplicando <= 12)
            {
                Console.WriteLine(+ tabla + " x " + multiplicando + " = " + tabla * multiplicando);
                multiplicando++;
            }
        }
    }
}
