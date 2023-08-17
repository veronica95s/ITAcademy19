using System;
class ContaCorrente {
    private decimal saldo;
    private DateTime dataCriacao;
    private string nomeTitular;
    private decimal acumuladorSaldo;
    private int contador;


    public void Depositar(decimal val)
    {
        if (val >= 0)
        {
            saldo += val;
            acumuladorSaldo += saldo;
            contador++;
        }
        else
        {
            Console.WriteLine("O valor do depósito não pode ser negativo.");
        }
    }

    public void Sacar(decimal val){
        if(val <= saldo){
            saldo = saldo - val;
            acumuladorSaldo += saldo;
            contador++;
        }else{
            Console.WriteLine("Saldo Insuficiente");
        }
    }

    public decimal Saldo
    {
    get { return saldo; }
    }
   
   public ContaCorrente(decimal val)
    {
    saldo = val;
    }

    public ContaCorrente(string nomeTitular)
    {
        this.nomeTitular = nomeTitular;
        this.dataCriacao = DateTime.Now;
        this.saldo = 0;
        this.acumuladorSaldo = 0;
        this.contador = 0;
    }

    public DateTime DataCriacao
    {
        get { return dataCriacao; }
    }

    public string NomeTitular
    {
        get { return nomeTitular; }
    }

     public decimal SaldoMedio
    {
        get { return contador > 0 ? acumuladorSaldo / contador : 0; }
    }

}
