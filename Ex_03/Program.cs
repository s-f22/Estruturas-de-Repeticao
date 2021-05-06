using System;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool teste_1, teste_2, teste_3, teste_4;
            string nome, std_cv;
            int idade;
            float salario;

            do
            {
                Console.WriteLine("Insira seu nome: ");
                nome = Console.ReadLine();

                if (nome == "")
                {
                    Console.WriteLine("Nome não digitado ou invalido. Tente novamente");
                    teste_1 = false;
                }
                else
                {
                    teste_1 = true;
                }

            } while (teste_1 == false);

            do
            {
                Console.WriteLine("Insira sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade < 0 || idade > 150)
                {
                    Console.WriteLine("Idade inválida. Tente novamente");
                    teste_2 = false;
                }
                else
                {
                    teste_2 = true;
                }

            } while (teste_2 == false);

            do
            {
                Console.WriteLine("Insira o valor do salário: ");
                string salario_string = Console.ReadLine();

                if (salario_string == "")
                {
                    salario_string = "0";
                }

                salario = float.Parse(salario_string);

                if (salario > 0)
                {
                    teste_3 = true;
                }
                else
                {
                    Console.WriteLine("Salário inválido. Tente novamente.");
                    teste_3 = false;
                }

            } while (teste_3 == false);

            do
            {
                Console.WriteLine("Insira o estado civil: (s)solteir@; (c)casad@; (v)viuv@; (d)divorciad@;");
                std_cv = Console.ReadLine().ToLower();

                if (std_cv == "s" || std_cv == "c" || std_cv == "v" || std_cv == "d")
                {
                    teste_4 = true;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    teste_4 = false;
                }

            } while (teste_4 == false);

            if (std_cv == "s")
            {
                std_cv = "Solteir@";
            }
            else if (std_cv == "c")
            {
                std_cv = "Casad@";
            }
            else if (std_cv == "v")
            {
                std_cv = "Viuv@";
            }
            else if (std_cv == "d")
            {
                std_cv = "Divorciad@";
            }

            Console.WriteLine("As informações cadastradas foram: ");
            Console.WriteLine("Nome: " + nome.ToUpper() + "\n" + "Idade: " + idade + "\n" + "Salário: R$" + Math.Round(salario, 2) + "\n" + "Estado civil: " + std_cv);
        }
    }
}
