namespace Laboratorio3;
class Program
{
    static void Main(string[] args)
    {
        /*
        Circulo circ1 = new Circulo();
        Console.WriteLine(circ1);
        Circulo circ2 = new Circulo(2.4, 5, 3);
        Console.WriteLine(circ2);
        */


        Circulo circ1 = new Circulo();
        Console.WriteLine(circ1);
        Circulo circ2 = new Circulo(2.4, 5, 3);
        Console.WriteLine(circ2);
        CirculoColorido circ3 = new CirculoColorido();
        Console.WriteLine(circ3);
        CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
        Console.WriteLine(circ4);
        Console.WriteLine("++------------------------------------------------++");


        // 1 - Uso das propriedades do círculo e círculo colorido.
            Console.WriteLine("CentroX do Círculo Colorido 4: " + circ4.CentroX);
            Console.WriteLine("CentroY do Círculo Colorido 4: " + circ4.CentroY);
            Console.WriteLine("++------------------------------------------------++");
       
        // 2 - CirculoColoridoPreenchido
            CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido(2.4, 5, 3, "vermelho", System.Drawing.Color.Blue);
            Console.WriteLine("Círculo Colorido Preenchido 5: " + circ5);
            Console.WriteLine("++------------------------------------------------++");


        // 3 - Crie uma array de objetos do tipo Circulo
            Circulo[] circulos = new Circulo[4];


        //3 - Preencha com instâncias de Circulo, CirculoColorido e CirculoColoridoPreenchido.
            circulos[0] = new Circulo(1, 1, 2);
            circulos[1] = new CirculoColorido(2, 2, 3, "azul");
            circulos[2] = new CirculoColoridoPreenchido(3, 3, 4, "verde", System.Drawing.Color.Yellow);
            circulos[3] = new Circulo();


        // 3 - Percorre o array  e imprime
            foreach (Circulo circulo in circulos)
            {
                Console.WriteLine(circulo);
            }


    }








}
