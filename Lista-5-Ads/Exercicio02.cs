using System;

public class Exercicio02
{

    int[] nota = new int[10];

    public void Rodar(){
        LerNotaAluno();
        CalcularMedia(nota);
    }

    public void LerNotaAluno(){
        for (int i = 0; i < 10; i++){
            Console.WriteLine("Digite a nota do aluno");
            nota[i] = int.Parse(Console.ReadLine());
        }
    }

    public void CalcularMedia(int[] nota){
        double soma = 0, media; 
        int cont = 0;
        
        for (int i = 0; i < 10; i++)
            soma += nota[i];
        media = soma / 10;

        Console.WriteLine("Média das notas informadas: " + media);

        for (int i = 0; i < 10; i++)
           if(nota[i] > media)
             cont++;

        Console.WriteLine("Número de notas acima da média : " + cont);
    }
}