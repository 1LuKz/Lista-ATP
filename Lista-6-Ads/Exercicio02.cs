using System;

public class Exercicio02
{
    public void Rodar()
    {
        Console.WriteLine("Digite uma frase: ");
        string userInput = Console.ReadLine();
        string updatedPhrase = GetPhraseWihoutVowels(userInput);
        Console.WriteLine(updatedPhrase);
    }

    static string GetPhraseWihoutVowels(string phrase)
    {
        string result = "";
        string vowels = "aeiouAEIOU";

        foreach (char character in phrase)
        {
            if (!vowels.Contains(character))
            {
                result += character;
            }
        }

        return result;
    }
}
