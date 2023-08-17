namespace Laboratorio2;
class Program
{
    static void Main(string[] args)
    {
        /*
        ContaCorrente minhaConta = new ContaCorrente();
        minhaConta.Depositar(100);
        minhaConta.Sacar(50);
        */


        /*
        ContaCorrente minhaConta = new ContaCorrente();
        Console.WriteLine(minhaConta.Saldo);
        minhaConta.Depositar(100);
        Console.WriteLine(minhaConta.Saldo);
        minhaConta.Sacar(50);
        Console.WriteLine(minhaConta.Saldo);
        */


       
         /*
        ContaCorrente minhaConta = new ContaCorrente(340);
        Console.WriteLine(minhaConta.Saldo);
        minhaConta.Depositar(100);
        Console.WriteLine(minhaConta.Saldo);
        minhaConta.Sacar(50);
        Console.WriteLine(minhaConta.Saldo);
        */



        /*
        ContaCorrente minhaConta = new ContaCorrente("Nome do Titular");
        minhaConta.Depositar(100);
        minhaConta.Sacar(50);
        Console.WriteLine($"Titular: {minhaConta.NomeTitular}");
        Console.WriteLine($"Data de Criação: {minhaConta.DataCriacao}");
        Console.WriteLine($"Saldo: {minhaConta.Saldo}");
        Console.WriteLine($"Saldo Médio: {minhaConta.SaldoMedio}");
        */




        ContaCorrente minhaConta = new ContaCorrente("Veronica");

        Console.WriteLine($"Titular: {minhaConta.NomeTitular}");
        Console.WriteLine($"Data de Criação: {minhaConta.DataCriacao}");
        Console.WriteLine($"Saldo Inicial: {minhaConta.Saldo}");
           
        // depositar valor negativo
        minhaConta.Depositar(-100);
           
        minhaConta.Depositar(1000);
        Console.WriteLine($"Saldo após depósito de 100: {minhaConta.Saldo}");


        minhaConta.Sacar(200);
        Console.WriteLine($"Saldo após saque de 50: {minhaConta.Saldo}");


        minhaConta.Depositar(50);
        Console.WriteLine($"Saldo após depósito de 200: {minhaConta.Saldo}");


        // Saldo insuficiente
         minhaConta.Sacar(3000);


        Console.WriteLine($"Saldo: {minhaConta.Saldo}");
        Console.WriteLine($"Saldo Médio: {minhaConta.SaldoMedio}");


    }
}
