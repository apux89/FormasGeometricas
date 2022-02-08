using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        private const string en = "en-En";
        private const string es = "es-ES";
        private const string it = "it-IT";
        [TestCase]
        public void TestResumenListaVacia()
        {
            FormaGeometrica f = new FormaGeometrica();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                f.Imprimir(new List<Forma>()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            FormaGeometrica f = new FormaGeometrica(en);
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                f.Imprimir(new List<Forma>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<Forma> { new Cuadrado(5) };
            FormaGeometrica f = new FormaGeometrica();
            var resumen = f.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 Formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            FormaGeometrica f = new FormaGeometrica(en);
            var cuadrados = new List<Forma>
                {
                    new Cuadrado(5),
                    new Cuadrado(1),
                    new Cuadrado(3)
                };

            var resumen = f.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            FormaGeometrica f = new FormaGeometrica(en);
            var formas = new List<Forma>
                {
                    new Cuadrado(5),
                    new Circulo(3),
                    new TrianguloEquilatero( 4),
                    new Cuadrado(2),
                    new TrianguloEquilatero(9),
                    new Circulo(2.75m),
                    new TrianguloEquilatero(4.2m)
                };

            var resumen = f.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 Shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            FormaGeometrica f = new FormaGeometrica(es);
            var formas = new List<Forma>
                {
                    new Cuadrado(5),
                    new Circulo(3),
                    new TrianguloEquilatero(4),
                    new Cuadrado(2),
                    new TrianguloEquilatero(9),
                    new Circulo(2.75m),
                    new TrianguloEquilatero(4.2m)
                };

            var resumen = f.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 Formas Perimetro 97,66 Area 91,65",
                resumen);
        }
        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            FormaGeometrica f = new FormaGeometrica(it);
            var formas = new List<Forma>
                {
                    new Cuadrado(5),
                    new Circulo(3),
                    new TrianguloEquilatero(4),
                    new Cuadrado(2),
                    new TrianguloEquilatero(9),
                    new Circulo(2.75m),
                    new TrianguloEquilatero(4.2m)
                };

            var resumen = f.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Rapporto di forma</h1>2 Cuadrados | La zona 29 | Perimetro 28 <br/>2 Circoli | La zona 13,01 | Perimetro 18,06 <br/>3 Triangulo | La zona 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 Forme Perimetro 97,66 La zona 91,65",
                resumen);
        }
        [TestCase]
        public void TestResumenListaVaciaItaliano()
        {
            FormaGeometrica f = new FormaGeometrica(it);
            Assert.AreEqual("<h1>Elenco di moduli vuoto!</h1>",
                f.Imprimir(new List<Forma>()));
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecio = new List<Forma> { new Trapecio(5,4,2,3,5) };
            FormaGeometrica f = new FormaGeometrica();
            var resumen = f.Imprimir(trapecio);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 12,5 | Perimetro 14 <br/>TOTAL:<br/>1 Formas Perimetro 14 Area 12,5", resumen);
        }

    }
}
