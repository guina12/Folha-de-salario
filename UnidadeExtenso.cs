using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class UnidadeExtenso
    {

        public string UnidadePorExtesno(int number)
        {
            if (number == 0)
            {
                return "zero";
            }

            else  if (number == 1)
                return " um ";

            else if (number == 2)
                return " dois ";

            else if (number == 3)
                return " tres ";

            else if (number == 4)
                return " quatro ";

            else if (number == 5)
                return " cinco ";

            else if (number == 6)
                return " seis ";

            else if (number == 7)
                return " sete ";

            else if (number == 8)
                return " oito ";

            else if (number == 9)
                return "nove";

            else
            {
                return "Número invalido";
                
            }
          

        }
    }
}
