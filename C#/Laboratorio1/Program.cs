// See https://aka.ms/new-console-template for more information

class Laboratorio1
{
    static void Main(string[] args)
    {
        // 1 - Trabalhando com tipos-valor fundamentais byte, int e long
        byte b;
        int i;
        long l;
        b = byte.MaxValue; 
        i = int.MaxValue;
        l = long.MaxValue;
        Console.WriteLine("Valor maximo de byte: " + b);
        Console.WriteLine($"Valor maximo de byte: {b}");
        Console.WriteLine("Valor maximo de int: " + i);
        Console.WriteLine("Valor maximo de long: " + l);
        Console.WriteLine("++-----------------------------------------------------++");
        

        // 2 - Trabalhando com strings
        string strPrimeira = "Alo "; 
        string strSegunda = "Mundo";
        string strTerceira = strPrimeira + strSegunda;
        Console.WriteLine(strTerceira);
        int cchTamanho = strTerceira.Length;
        string strQuarta = "Tamanho = " + cchTamanho.ToString(); 
        Console.WriteLine(strQuarta);
        Console.WriteLine(strTerceira.Substring(0, 5));
        Console.WriteLine("++-----------------------------------------------------++");
        
        // 3 - Trabalhando com objetos do Framework
        DateTime dt = new DateTime(2015, 04, 23);
        string strQuinta = dt.ToString();
        Console.WriteLine(strQuinta);
        Console.WriteLine("++-----------------------------------------------------++");


        // 4 - Exercícios

        // 1 - Float, double, e decimal

        float f;
        double d;
        decimal de;
        float fm;
        
        f = float.MaxValue;
        d = double.MaxValue;
        de = decimal.MaxValue;

        fm = float.MinValue;

        Console.WriteLine("Valor maximo de float: " + f);
        Console.WriteLine("Valor minimo de float: " + fm);
        Console.WriteLine("Valor maximo de decimal: " + de);
        Console.WriteLine("Valor maximo de doable: " + d);
        Console.WriteLine("++-----------------------------------------------------++");

        // 2 - Operações da classe String

        char[] chars = { 'g', 'a', 't', 'o' };
        sbyte[] bytes = { 0x41, 0x42, 0x43, 0x44, 0x45, 0x00 };
        // Cria uma string com os caracteres
        string string1 = new string(chars);
        Console.WriteLine(string1);

        string stringdata = "Today is " + DateTime.Now.ToString("D") + ".";
        Console.WriteLine(stringdata);
        Console.WriteLine("++-----------------------------------------------------++");

        // 3 - Operações da classe DateTime

        // Data e hora atual
        DateTime now = DateTime.Now;
        Console.WriteLine("Data e hora atual: " + now);

        // Adiccionar um período de tempo
        DateTime semana = now.AddDays(7);
        Console.WriteLine("Daqui a uma semana será dia: " + semana);
        Console.WriteLine("++-----------------------------------------------------++");
        
        // 4 - Converçãp de dados em C#
        int ii = 10; 
        float ff = 0; 
        ff = ii; //conversão implícita, sem perda de dados. 
        System.Console.WriteLine(ff); 
        ff = 0.5F; 
        ii = (int) ff; //conversão explícita, com perda de dados. 
        System.Console.WriteLine(ii); 
        Console.WriteLine("++-----------------------------------------------------++");

        // 5 - System.Convert
        string stringInteiro = "123456789"; 
        int valorStringInteiro = Convert.ToInt32(stringInteiro); 
        Console.WriteLine(valorStringInteiro); 
        Int64 valorInt64 = 123456789; 
        int valorInt = Convert.ToInt32(valorInt64); 
        Console.WriteLine(valorInt);
        /*
        string stringInteiroGrande = "999999999999999999999999999999999999999999999"; 
        int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande); 
        */
        Console.WriteLine("++-----------------------------------------------------++");

        // 6 -  TryParse
        string stringInt = "123456789"; 
        int valorStringInt; 
        bool conversao1 = Int32.TryParse(stringInt, out valorStringInt); 
        Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInt); 
        
        
        string stringInteiroGr = "999999999999999999999999999999999999999999999"; 
        int valorStringInteiroGr; 
        bool conversao2 = Int32.TryParse(stringInteiroGr, out valorStringInteiroGr); 
        Console.WriteLine("Conversão efetuada:" + conversao2 + " Valor: " + valorStringInteiroGr); 
        
        string stringLetras = "abc"; 
        double valorStringLetras; 
        bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
        Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);
        Console.WriteLine("++-----------------------------------------------------++");

        // 7 - Arredondamentos

        double valorFracionado = 4.7; 
        int valorInteiro1 = (int) valorFracionado; 
        int valorInteiro2 = Convert.ToInt32(valorFracionado); 
        Console.WriteLine("Conversao explicita = " + valorInteiro1); 
        Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);
        Console.WriteLine("++-----------------------------------------------------++");

        // 8 -  Sintaxe para a exibição de valores de várias variáveis

        int x = 10; 
        double y = 3.4; 
        // 0 e 1 ondica onde as variaveis x e y seram inseridas na string.
        Console.WriteLine("{0}  {1}",x,y); 
        // $ interpolação de string - permite colocar as variaveis diretamente na string.
        Console.WriteLine($"{x} {y}"); 



        Console.WriteLine(args.Length);
    }
}