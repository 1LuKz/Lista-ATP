using System;

public class Exercicio01
{
    public void Rodar()
    {
        calcularMedia();
    }

    public void calcularMedia()
    {
        double num1, num2, num3;

        Console.WriteLine("Informe a primeira nota: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota: ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a terceira nota: ");
        num3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe:");
        Console.WriteLine("A) Para calcular a média aritmética.");
        Console.WriteLine("P) Para calcular a média ponderada.");
        string escolha = Console.ReadLine();

        switch (escolha.ToLower())
        {
            case "a":
                mediaAritmetica(num1, num2, num3);
                break;
            case "p":
                mediaPonderada(num1, num2, num3);
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    public void mediaAritmetica(double num1, double num2, double num3)
    {
        double media = (num1 + num2 + num3) / 3;
        Console.WriteLine("Média aritmética: " + media);

    }

    public void mediaPonderada(double num1, double num2, double num3)
    {
        double media = (num1 * 5 + num2 * 3 + num3 * 2) / (5 + 3 + 2);
        Console.WriteLine("Média ponderada: " + media);
    }
}