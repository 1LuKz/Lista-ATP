using System;

public class Exercicio01
{
    public void Rodar()
    {
        string userInput;
        int quantityOfWhiteSpaces = 0;

        Console.WriteLine("Digite uma frase: ");
        userInput = Console.ReadLine();
        foreach (char character in userInput)
        {
            if (character == ' ')
            {
                quantityOfWhiteSpaces++;
            }
        }

        Console.WriteLine("O numero de espacos em branco eh de: " + quantityOfWhiteSpaces);
    }
}
