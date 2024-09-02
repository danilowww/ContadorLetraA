using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string para verificar a presença da letra 'a': ");
        string input = Console.ReadLine();

        int count = CountLetterA(input);

        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) ocorre {count} vez(es) na string fornecida.");
        }
        else
        {
            Console.WriteLine("A letra 'a' (maiúscula ou minúscula) não ocorre na string fornecida.");
        }
    }

    static int CountLetterA(string text)
    {
        int count = 0;

        if (text != null)
        {
            foreach (char c in text)
            {
                if (c == 'a' || c == 'A')
                {
                    count++;
                }
            }
        }

        return count;
    }
}