using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class Forma
    {

        private readonly decimal _lado;
       
        protected decimal getLado()
        {
            return _lado;
        }
       

        public Forma(decimal lados)
        {
            _lado = lados;
        }
        public Forma()
        {
        }
        public abstract string TraducirForma(Traductor traductor);
        public abstract string TraducirMultipleForma(Traductor traductor);
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();

        public string ObtenerLinea(int cantidad, string forma, decimal area, decimal perimetro,Traductor traductor)
        {
            return $"{cantidad} {forma} | {traductor.Traducir("area")} {area:#.##} | {traductor.Traducir("perimetro")} {perimetro:#.##} <br/>";
        }

    }
}
