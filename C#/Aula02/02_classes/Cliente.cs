class Cliente
{
    public const string tipo = "Pessoa";
    private string atributoNome;
    public string PropriedadeNome{
        get{return atributoNome;}
        set{atributoNome=value;}
    }
    private decimal limitedCredito;
    private uint ClienteID;

    public void saudacao(){
        Console.WriteLine("Olá");
    }

    public void AumentarLimite(decimal valor){
        limitedCredito += valor;
    }

    public decimal consultalimite(){
        return limitedCredito;
    }

    public void MetodoOut1(int a, out int b){
        b = a*200;
    }

    public void MetodoOutNormal(int a, int b){
        b = 200*a;
    }

    public void MetodoOutRef1(int a, ref int b){
        b += a;
    }

    public void MetodoParam(params int [] listadeParemetros){
        for(int i=0; i<listadeParemetros.Length; i++)
            Console.WriteLine(" param["+i+"]: " + listadeParemetros[i]);
    }



    
    
}