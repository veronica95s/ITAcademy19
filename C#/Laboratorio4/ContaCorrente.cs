public abstract class ContaCorrente{
    private decimal saldo;
    private string titular;
    public ContaCorrente(string t)
    {
    titular = t;
    }

    public decimal Saldo
    {
    get { return saldo; }
    }

    public string Titular
    {
    get { return titular; }
    }

    public abstract string Id
    {
    get;
    }

    public virtual void Depositar(decimal valor)
    {
    saldo += valor;
    }


    public virtual void Sacar(decimal valor)
    {
    saldo -= valor;
    }

     public virtual void MostrarDados()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo:C}");
        Console.WriteLine($"ID: {Id}");
    }


    


}