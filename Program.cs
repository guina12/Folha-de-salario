using ConsoleApp12;

namespace Curse
{
    class Curse
    {

        static void Main(string[] args)
        {
            int x = 1;

            while (x > 0)
            {
                Console.Write("Insira um digito:");
                string number = Console.ReadLine();
                int nro = 0;


                try
                {

                    nro = Convert.ToInt32(number);
                }

                catch
                {
                    Console.WriteLine("Erro Número invalido");
                    return;

                }

                string retorno = "";


                switch (number.Length)
                {
                    case 1:
                        UnidadeExtenso unidade = new UnidadeExtenso();
                        retorno = unidade.UnidadePorExtesno(nro);
                        break;

                    case 2:
                        Dezena dezena = new Dezena();
                        retorno = dezena.DezenaPorExtenso(nro);
                        break;


                    case 3:
                        Centena centena = new Centena();
                        retorno = centena.CentenaPorExtenso(nro);
                        break;



                }


                Console.WriteLine(retorno);
                Console.WriteLine("");
                Console.Write("Desaja Continuar :");
                char choice = char.Parse(Console.ReadLine());

                if (choice == 'S' || choice == 's')
                {
                    x = x + 1;
                }
                else if (choice == 'N' || choice == 'n')
                {
                    x = x - 100;
                    Console.WriteLine("Muito obrigado");

                }
            }
        }
    }
}
