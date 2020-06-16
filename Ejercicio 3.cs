using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long numero;
            int digitos = 0;

            Console.Write("Introduce un numero positivo: ");
            numero = Convert.ToInt64(Console.ReadLine());

            do
            {
                if(numero < 0)
                {
                    while(numero < 0)
                    {
                        Console.WriteLine("El numero que introdujo es negativo");
                        Console.WriteLine();
                        Console.Write("Introduzca un numero positivo: ");
                        numero = Convert.ToInt64(Console.ReadLine());
                    }
                }
                numero = numero / 10;
                digitos++;
            }
            while(numero > 0);

            Console.WriteLine("El numero que introdujo tiene {0} digito", digitos);
        }
    }
}
