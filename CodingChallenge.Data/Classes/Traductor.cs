using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Traductor
    {
        ResourceManager recMan;
        CultureInfo CulInfo;
        public Traductor() {

            recMan = new ResourceManager("CodingChallenge.Data.Recursos.Lenguaje", Assembly.GetExecutingAssembly());
            this.CulInfo = new CultureInfo("es-ES");
        }
        public Traductor(string cultura)
        {

            recMan = new ResourceManager("CodingChallenge.Data.Recursos.Lenguaje", Assembly.GetExecutingAssembly());
            this.CulInfo = new CultureInfo(cultura);
        }

        public void CambiarIdioma(string cultura)
        {
            CulInfo = new CultureInfo(cultura);
        }

        public string Traducir(string palabra) {

            return recMan.GetString(palabra,CulInfo);
        }
    }
}
