/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        private readonly Traductor traductor;
        
        public FormaGeometrica(string cultura)
        {
            traductor = new Traductor(cultura);
        }
        public FormaGeometrica()
        {
            traductor = new Traductor();
        }
        public string Imprimir(List<Forma> lista)
            {
            var sb = new StringBuilder();
            decimal area = 0;
            decimal perimetro = 0;
            decimal areaTotal = lista.Sum(x => x.CalcularArea());
            decimal perimetroTotal = lista.Sum(x => x.CalcularPerimetro());
            int cantidadForma = lista.Count();
            if (!lista.Any()) {
                sb.Append(traductor.Traducir("listaVacia"));
            }
            else
            {
                sb.Append(traductor.Traducir("reporte"));


                while (lista.Any())
                {
                    Forma f = lista.First();
                    List<Forma> aux = lista.Where<Forma>(x => f.GetType().IsInstanceOfType(x)).ToList();
                    foreach (Forma forma in aux) {
                        lista.Remove(forma);
                        area += forma.CalcularArea();
                        perimetro += forma.CalcularPerimetro();
                    }
                    string nombreForma = (aux.Count() > 1) ? f.TraducirMultipleForma(traductor) : f.TraducirForma(traductor);
                    sb.Append(f.ObtenerLinea(aux.Count(), nombreForma, area, perimetro,traductor));
                    area = 0;
                    perimetro = 0;

                }
                string formas = (cantidadForma > 0) ? traductor.Traducir("formas") : traductor.Traducir("forma");
                sb.Append(traductor.Traducir("total"));
                sb.Append($"{cantidadForma} {formas} {traductor.Traducir("perimetro")} {perimetroTotal:#.##} {traductor.Traducir("area")} {areaTotal:#.##}");
             }

            return sb.ToString();
        }
   
    }
}
