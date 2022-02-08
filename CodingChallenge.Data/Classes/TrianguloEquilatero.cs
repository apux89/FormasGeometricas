using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero:Forma
    {
        public TrianguloEquilatero(decimal lado) : base(lado)
        {
        }
    
        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * getLado() * getLado();
        }

        public override decimal CalcularPerimetro()
        {
            return getLado() * 3;
        }
        public override string TraducirForma(Traductor traductor)
        {
            return traductor.Traducir("triangulo");
        }

        public override string TraducirMultipleForma(Traductor traductor)
        {
            return traductor.Traducir("triangulos");
        }
    }
}
