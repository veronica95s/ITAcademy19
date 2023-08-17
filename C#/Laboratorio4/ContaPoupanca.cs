public class ContaPoupanca : ContaCorrente{

    private decimal taxaJuros;
    private DateTime dataAniversario;


    public ContaPoupanca(decimal j, DateTime d, string t)
    : base(t)
    {
    taxaJuros = j;
    dataAniversario = d;
    }


    public decimal Juros
    {
    get { return taxaJuros; }
    set { taxaJuros = value; }
    }
    public DateTime DataAniversario
    {
    get { return dataAniversario; }
    }

        public override string Id
    {
    get { return this.Titular + "(CP)"; }
    }
    
}