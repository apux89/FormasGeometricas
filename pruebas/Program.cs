using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Forma> lista = new List<Forma>();

            lista.Add(new Cuadrado(3, "es-ES"));
            lista.Add(new Cuadrado(2, "es-ES"));
            lista.Add(new Circulo(3, "en-EN"));
            FormaGeometrica fg = new FormaGeometrica();
            Console.WriteLine(fg.imprimir(lista));
        }
    }
}
