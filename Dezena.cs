using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Dezena
    {
        public string DezenaPorExtenso(int number)


        {
            string retorno = "";
            string nro = "";
            UnidadeExtenso unidade = new UnidadeExtenso();
            if (number == 10)
            {
                return "dez";
            }

            else if (number == 11)
            {
                return "onze";
            }

            else if (number == 12)
            {
                return "doze";
            }

            else if (number == 13)
            {
                return "treze";
            }

            else if (number == 14)
            {
                return "Quatorze";
            }

            else if (number == 15)
            {
                return "Quinze";
            }

            else if (number == 16) { 
                return "Dezasseis";
                
            }

           else  if (number == 17)
            {
                return "dezassete";
            }

            if (number == 18)
            {
                return "Dezoito";
            }

            if (number == 19)
            {
                return "Dezanove";
            }

            else if (number == 20)
            {
                return "vinte";
            }
            else if (number > 20 && number <= 29)
            {
                retorno = " vinte e";
                nro = Convert.ToString(number);
                nro = nro.Substring(1, 1);
                retorno += unidade.UnidadePorExtesno(Convert.ToInt32(nro));
            }

            else if (number == 30)
            {
                return "trinta";
            }

            else if (number>30 && number<=39)
            {
                retorno = "Trinta e";
                nro = Convert.ToString(number);
                nro = nro.Substring(1, 1);
                retorno += unidade.UnidadePorExtesno(Convert.ToInt32(nro));
            
            }  
            
            else if (number == 40)
            {
                return "Quarente";
            }

            else if (number> 40 && number <= 49)
            {
                retorno = "Quarenta e ";
                nro = Convert.ToString(number);
                nro = nro.Substring(1, 1);
                retorno += unidade.UnidadePorExtesno(Convert.ToInt32(nro));
            }


            else if (number == 50)
            {
                return "Cinquenta";
            }
            

            else if (number > 50 && number <= 59)
            {
                retorno = "Cinquenta  e ";
                nro = Convert.ToString(number);
                nro = nro.Substring(1, 1);
                retorno += unidade.UnidadePorExtesno(Convert.ToInt32(nro));
            }

            else if (number == 60)
            {
                return "sessenta";
            }
            else if (number > 60 && number <= 69)
            {
                retorno = "Sessenta e ";
                nro= Convert.ToString(number);
                nro= nro.Substring(1, 1);
                retorno += unidade.UnidadePorExtesno(Convert.ToInt32(nro));
            }

            else if (number ==70)
            {
                return "Setenta";
            }

            else if (number > 70 && number <= 79)
            {
                retorno = "Setenta e ";
                nro = Convert.ToString(number);
                nro = nro.Substring(1, 1);
                retorno += unidade.UnidadePorExtesno(Convert.ToInt32(nro));

            }

            else if (number == 80)
            {
                return "Oitenta";
            }

            else if (number > 80 && number <= 89)
            {
                retorno = " Oitenta e ";
                nro = Convert.ToString(number);
                nro = nro.Substring(1, 1);
                retorno += unidade.UnidadePorExtesno(Convert.ToInt32(nro));
            }

            else if (number == 90)
            {
                return "Noventa";
            }
            else if (number >90 && number <= 99)
            {
                retorno = "Noventa e ";
                nro= Convert.ToString(number);
                nro= nro.Substring(1, 1);
                retorno += unidade.UnidadePorExtesno(Convert.ToInt32(nro));
            }


            return retorno;

        }
    }
}
