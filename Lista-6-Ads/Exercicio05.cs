using System;
public class Exercicio05
{
    public void Rodar()
    {
        int qnt = 0;
        StreamReader sr = new StreamReader("./Files/exercise.txt");
        string line = sr.ReadLine();
        Console.WriteLine("Conteudo do arquivo: ");
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
            qnt++;
        }
        Console.WriteLine("A quantidade de linhas eh: " + qnt);
        sr.Close();
    }
}
