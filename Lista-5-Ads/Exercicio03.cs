using System;

public class Exercicio03{

    int[] vetor = new int[10];
    public void Rodar(){
        Vetor();
        NumerosNegativos(vetor);
    }

    public void Vetor(){
        for(int i = 0 ; i < 10; i++){
            Console.WriteLine("Digite um número");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    public int NumerosNegativos(int[] vetor){
        int[] vetorNegativo = new int[10];

        foreach(int negativos in vetor){
            if(negativos < 0){
                vetorNegativo[0] = negativos;
            }
        }
        return vetorNegativo.Length;
    }
}