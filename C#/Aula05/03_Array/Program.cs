namespace _03_Array;
class Program
{
    static void Main(string[] args)
    {
        ﻿int? [] vetor = new int?[10];
        Random rnd = new Random();

        for(int i=0; i<vetor.Length; i++)
            vetor[i]=rnd.Next(101);

        for(int i=0; i<vetor.Length; i++)
        Console.WriteLine($"[{i}]: {vetor[i]}");

        Console.WriteLine("\\-=-=-=-=-=-=-");
        foreach(int valor in vetor)
        Console.WriteLine($"fe => {valor}");
    }
}
