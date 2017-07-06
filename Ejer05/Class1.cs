using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer05
{
    public class Data
    {
        public string text = "Hola mundo";
        public int number1 = 1;
        public int number2 = 2;

    }

    public class Metodo : Data
    {
        Data datos = new Data();
        public string Concatenar()
        {
            return datos.text + "-" + datos.number1 + "-" + datos.number2;
        }
    }
}
