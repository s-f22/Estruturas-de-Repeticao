using System;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool controle;

            Console.WriteLine("Insira seu nome de usuário: ");
            string nome =  Console.ReadLine();

            do
            {

            Console.WriteLine("Insira sua senha: ");
            string senha =  Console.ReadLine();
            
            if (nome != senha)
            {
                Console.WriteLine("Cadastro efetuado com sucesso!");
                controle = true;
            }
            else
            {
                Console.WriteLine("Senha inválida. Valores repetidos.");
                controle = false;
            }

            } while (controle == false);
        }
    }
}
