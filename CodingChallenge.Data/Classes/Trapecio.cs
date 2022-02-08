using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : Forma
    {
        private decimal _lado1 { get; set; }
        private decimal _lado2 { get; set; }
        private decimal _base1 { get; set; }
        private decimal _base2 { get; set; }
        private decimal _altura { get; set; }

        public Trapecio(decimal lado1, decimal lado2, decimal base1, decimal base2, decimal altura)
        {
            this._lado1 = lado1;
            this._lado2 = lado2;
            this._base1 = base1;
            this._base2 = base2;
            this._altura = altura;

        }

        public override decimal CalcularArea()
        {
            return _altura * ((_base1 + _base2) / 2); 
        }

        public override decimal CalcularPerimetro()
        {
            return _base1 + _base2 + _lado1 + _lado2;
        }
        public override string TraducirForma(Traductor traductor)
        {
            return traductor.Traducir("trapecio");
        }

        public override string TraducirMultipleForma(Traductor traductor)
        {
            return traductor.Traducir("trapecios");
        }
    }
}
