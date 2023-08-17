namespace _02_classes;
class Program
{
    static void Main(string[] args)
    {
        Cliente c = new Cliente();
        Console.WriteLine(c);
        // Acessando uma constante
        // Console.WriteLine(c.tipo); Não aceitou como objetoe causou erro de composição
        Console.WriteLine(Cliente.tipo);

        // Acessando um método oublico da classe cliente
        c.saudacao();
        // Cliente.saudacao(); Objeto tem que existir, n pode acessar só pela classe

        // Acessando o metodo para manipulação do limite de credito
        Console.WriteLine("O limite de crédito é " + c.consultalimite());
        Console.WriteLine("Adicionando R$ 50,00 de limite ");
        c.AumentarLimite(50);
        Console.WriteLine("O limite de crédito é " + c.consultalimite());

        // Explorando método com o parametro out
        int a = 10;
        int b;

        Console.WriteLine("Antes da chamada do método com out");
        Console.WriteLine("O valor de a é: " + a);
        //Console.WriteLine("O valor de b é: " + b);
        c.MetodoOut1(a, out b);
        Console.WriteLine("Depos da chamada do método com out");
        Console.WriteLine("O valor de a é: " + a);
        Console.WriteLine("O valor de b é: " + b);

        Console.WriteLine("Antes da chamada do método com ref");
        Console.WriteLine("O valor de a é: " + a);
        c.MetodoOutRef1(a, ref b);
        Console.WriteLine("Depos da chamada do método com ref");
        Console.WriteLine("O valor de a é: " + a);
        Console.WriteLine("O valor de b é: " + b);

        Console.WriteLine("Uma lista de fato");
        int [] minhalista = new int[4] {1,2,3,4};
        c.MetodoParam(minhalista);

        Console.WriteLine("Nome do cliente é: " +c.PropriedadeNome);
        c.PropriedadeNome = "Edson Moreno";
        Console.WriteLine("Nome do cliente é: " +c.PropriedadeNome);
    }

}
