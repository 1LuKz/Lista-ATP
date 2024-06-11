using System;

public class Exercicio04(){

    public void Rodar(){
        triangulo();
    }

    public void triangulo(){
        Console.WriteLine("Digite o valor de X");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de Y");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de Z");
        int z = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha qual tipo de triângulo (Eq/Is/Es)");
        string escolha = Console.ReadLine();

        switch(escolha){
            case "Eq":
                trianguloEquilatero(x, y, z);
                break;

            case "Is":
                trianguloIsosceles(x, y, z);
                break;

            case "Es":
                trianguloEscaleno(x, y, z);
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }

    public void trianguloEquilatero(int x, int y, int z){
        if ((x == y)&&(x == z)){
            Console.WriteLine("O triângulo é Equilátero");
        }
    }

    public void trianguloIsosceles(int x, int y, int z){
        if((x == y)&&(x == z)){
            Console.WriteLine("O triângulo é Isósceles");
        }
    }

    public void trianguloEscaleno(int x, int y, int z){
        if((x != y)||(x != z)||(y != z)){
            Console.WriteLine("O triângulo é Escaleno");
        }
    }

} 