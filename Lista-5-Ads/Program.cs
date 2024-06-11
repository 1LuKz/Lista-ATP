using System;

public class Program
{
    static void Main()
    {

        Console.WriteLine("Digite qual exercício que deseja :");
        int exercicio = int.Parse(Console.ReadLine());

        switch (exercicio)
        {
            case 1:
                Exercicio01 exercicio01 = new Exercicio01();
                exercicio01.Rodar();
                break;
            case 2:
                Exercicio02 exercicio02 = new Exercicio02();
                exercicio02.Rodar();
                break;
            case 3:
                Exercicio03 exercicio03 = new Exercicio03();
                exercicio03.Rodar();
                break;
            default:
                Console.WriteLine("Número inválido");
                break;
        }
    }
}