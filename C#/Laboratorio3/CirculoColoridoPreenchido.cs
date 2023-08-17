using System;
using System.Drawing;


namespace Laboratorio3
{
    public class CirculoColoridoPreenchido : CirculoColorido
    {
        public Color CorPreenchimento { get; set; }


        public CirculoColoridoPreenchido()
            : base()
        {
            CorPreenchimento = Color.White;
        }


        public CirculoColoridoPreenchido(double x, double y, double r, string corBorda, Color corPreenchimento)
            : base(x, y, r, corBorda)
        {
            CorPreenchimento = corPreenchimento;
        }


        public override string ToString()
        {
            return base.ToString() + " corPreenchimento=" + CorPreenchimento.Name;
        }
    }
}
