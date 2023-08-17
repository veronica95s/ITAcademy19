namespace Laboratorio4;
class Program
{
    static void Main(string[] args)
    {
        ContaPoupanca contaPoupanca = new ContaPoupanca(0.05m, new DateTime(2023, 8, 10), "Alice");
        ContaCorrente contaCorrente = new ContaCorrente("Bob");

        contaPoupanca.Depositar(1000);
        contaCorrente.Depositar(1500);

        contaPoupanca.Sacar(200);
        contaCorrente.Sacar(300);

        Console.WriteLine("Dados da Conta Poupança:");
        contaPoupanca.MostrarDados();

        Console.WriteLine("\nDados da Conta Corrente:");
        contaCorrente.MostrarDados();

    }
}
