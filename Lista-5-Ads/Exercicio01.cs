using System;

public class Exercicio01
{
    int[] vetor = new int[20];
    public void Rodar()
    {
        lerDadosVetor();
        imprimirDadosVetor();
        menorDadoVetor();
    }

    public void lerDadosVetor()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Informe um número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    public void imprimirDadosVetor()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(i + ") " + vetor[i]);
        }
    }

    public void menorDadoVetor()
    {
        int pos = 0, menor = vetor[0];
        for (int i = 1; i < 20; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
                pos = i;
            }
        }
        Console.WriteLine("O menor elemento do Vetor é " + menor +  " e ele está na posição " + pos);
    }
}