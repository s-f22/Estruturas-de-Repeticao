using System;

namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSEQUENCIA DE FIBONACCI até 500\n");
            int anterior = 0;
            int atual = 1;

            while (anterior <= 500)
            {
                atual = atual + anterior;
                Console.Write(anterior + ", ");
                anterior = atual - anterior;
            }
            Console.Write("\n\n\n");
            // do
            // {
            //     atual = atual + anterior;
            //     Console.Write(atual + ", ");
            //     anterior = atual - anterior;

            // } while (atual <= 500);

        }
    }
}
