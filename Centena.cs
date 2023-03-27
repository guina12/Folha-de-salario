using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Centena
    {
        public string  CentenaPorExtenso(int number)

           
        {

            string retorno = "";
            string nro = "";
            Dezena dezena = new Dezena();
            UnidadeExtenso unidade = new UnidadeExtenso();
            if (number == 100)
            {
                return "cem";
            }

            else  if (number==101)
            {
                return "cento e um";

            }
            else if (number == 102)
            {
                return "cento e 2";

            }

            else if (number == 103)
            {
                return "cento e 3";
            }

            else if (number == 103)
            {
                return "cento e 3";
            }

            else if (number == 104)
            {
                return "cento e 4";
            }

            else if (number == 105)
            {
                return "cento e 5";
            }

            else if (number == 106)
            {
                return "cento e 6";
            }

            else if (number == 107)
            {
                return "cento e 7";
            }

            else if (number == 108)
            {
                return "cento e 8";
            }

            else if (number == 109)
            {
                return "cento e 9";
            }

            else if (number > 109 && number <=199)
            {
                retorno = "Cento e ";
                nro = Convert.ToString(number);
                nro = nro.Substring(1, 2);
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(nro));
            }


            else if ( number == 200)
            {
                return "duzentos ";
            }


            return retorno;

        }
        
    }
}
