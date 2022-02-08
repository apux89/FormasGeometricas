using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo: Forma { 


    public Circulo(decimal lado) : base(lado)
    {
    }

    public override decimal CalcularArea()
    {
        return  (decimal)Math.PI * (getLado() / 2) * (getLado() / 2);
    }

    public override decimal CalcularPerimetro()
    {
        return  (decimal)Math.PI * getLado();
    }

    public override string TraducirForma(Traductor traductor)
    {
        return traductor.Traducir("circulo");
    }

    public override string TraducirMultipleForma(Traductor traductor)
        {
        return traductor.Traducir("circulos");
    }
}
}
