using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : Forma { 


        public Cuadrado(decimal lados):base(lados) 
        { 
        }
        public override decimal CalcularArea()
        {
            return getLado() * getLado();
        }

        public override decimal CalcularPerimetro()
        {
            return getLado() * 4;
        }

        public override string TraducirForma(Traductor traductor)
        {
            return traductor.Traducir("cuadrado");
        }

        public override string TraducirMultipleForma(Traductor traductor)
        {
            return traductor.Traducir("cuadrados");
        }
    }
}
