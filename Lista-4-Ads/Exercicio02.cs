using System;

public class Exercicio02 {
    
    public void Rodar(){
        prefeitura();
    }
    public void prefeitura(){
        string repertir;
        int contador = 0;

        do {
            contador++;

            Console.WriteLine("Digite o salário");
            double salarioHabitantes = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de filhos que a cidade tem");
            double qtdFilhos = double.Parse(Console.ReadLine());

            Console.WriteLine("Deseja continuar? (s/n)");
            repertir = Console.ReadLine();

        } while(repertir.ToLower() == "s");
    }

    public void mediaSalario(int contador, double salarioHabitantes){
        double media = salarioHabitantes / contador;
    }
}