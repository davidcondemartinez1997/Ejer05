using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer05
{
    public class Data
    {
        public string text;
        public int number1;
        public int number2;

        public Data(string text, int number1, int number2)
        {
            this.text = text;
            this.number1 = number1;
            this.number2 = number2;

        }

    }

    public class Metodo
    {
        private Data datos;
        public Metodo(string text, int number1, int number2)
        {
            this.datos = new Data(text, number1, number2);
        }
        

        public string Concatenar()
        {
            return datos.text + "-" + datos.number1 + "-" + datos.number2;
        }
    }
}
