namespace _01_ClasseAbstrata;
class Program
{
    static void Main(string[] args)
    {
        Gato g = new();
        Console.WriteLine(g);
        g.emitirSom();

        Cachorro c = new();
        Console.WriteLine(c);
        c.emitirSom();

        
    }

    
}
