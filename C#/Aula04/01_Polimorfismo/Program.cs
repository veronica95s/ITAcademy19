namespace _01_Polimorfismo;
class Program
{
    static void Main(string[] args)
    {
        
        Pessoa p = new("Edson", 46);
        Console.Write(p);

        p.anoDeNascimento = 1990;
        Console.Write(p);
       

        Funcionario f = new Funcionario(1500.13M);
        Console.WriteLine(f);

        f = new("Edson", 46, 1800);
        Console.WriteLine(f);
        
        Pessoa paux;
        paux = p;
        Console.WriteLine("Pessoa");
        Console.WriteLine(paux);
        Console.WriteLine("Qual o humor?"+paux.humor());
        paux = f;
        Console.WriteLine("Funcionário");
        Console.WriteLine(paux);
        Console.WriteLine("Qual o humor?"+paux.humor());
        Console.WriteLine("Está satisfeito com o salario? "+((Funcionario)paux).satisfacaoSalarial());
        Console.WriteLine("++---------------------------++\n");

        object oaux;
        oaux = p;
        Console.WriteLine("oPessoa");
        Console.WriteLine(oaux);
        Console.WriteLine("Qual o humor?"+((Pessoa)oaux).humor());
        Console.WriteLine("++---------------------------++\n");

        oaux = f;
        Console.WriteLine("oFuncionário");
        Console.WriteLine(oaux);
        Console.WriteLine("Está satisfeito com o salario? "+((Funcionario)paux).satisfacaoSalarial());
        Console.WriteLine("++---------------------------++\n");
    }
}
