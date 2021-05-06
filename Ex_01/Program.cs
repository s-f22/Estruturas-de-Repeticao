using System;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool controle;

            do
            {

            Console.WriteLine("Insira uma nota de 0 a 10: ");
            float nota = float.Parse(Console.ReadLine());

            if (nota >= 0 && nota <= 10)
            {
                Console.WriteLine("Nota " + nota + " inserida com sucesso.");
                controle = true;
            }
            else
            {
                Console.WriteLine("Nota Invalida. Tente novamente.");
                controle = false;
            }

            } while (controle == false);
        }
    }
}
