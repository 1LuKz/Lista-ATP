using System;

public class Program
{
    public static void Main()
    {
        Exercicio01 exercicio01 = new Exercicio01();
                    exercicio01.Rodar();
        /* while (true)
        {
            Console.WriteLine("Informe:");
            Console.WriteLine("1) Para executar o exercício 01.");
            Console.WriteLine("2) Para executar o exercício 02.");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Exercicio01 exercicio01 = new Exercicio01();
                    exercicio01.Rodar();
                    break;
                case 2:
                    Exercicio02 exercicio02 = new Exercicio02();
                    exercicio02.Rodar();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } */
    }
}