using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string respuesta;

            do
            {
                Random aleatorio = new Random();
                numero = aleatorio.Next(1, 101);

                Console.WriteLine("El numero generado aleatoriamente es: " + numero);

                Console.WriteLine();

                Console.Write("Para finalizar Pulse (S), Si quiere seguir generando numero Pulse cualquier letra: ");
                respuesta = Console.ReadLine();

            }
            while (respuesta != "S");
            Console.WriteLine("Ya no se generan mas numeros");
        }
    }
}
