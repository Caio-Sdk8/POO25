using System;
using polimorfismo.classes;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rep = false;

            Console.WriteLine("Bem vindo a Super CafeteiraTabajaras Plus+");
            maquinaCafe tabajara = new maquinaCafe();
            tabajara.AcucarDisp = 500;
            do
            {

                Console.WriteLine(@"Você deseja uma quantidade de açucar personalizada? s-sim    n-não
            !!!AVISO!!! = caso não escolha um valor, será colocado o valor padrão(10g).");
                string resposta = Console.ReadLine();

                if (resposta == "s")
                {
                    tabajara.AcucarDisp = tabajara.AcucarDisp - tabajara.quantidade;

                    tabajara.FazerCafé(tabajara.AcucarDisp);
                }
                else if (resposta == "n")
                {
                    tabajara.AcucarDisp = tabajara.AcucarDisp - tabajara.quantidade;

                    tabajara.FazerCafé();
                }

                Console.WriteLine("deseja mais um café?");
                string querocafe = Console.ReadLine();

                if (querocafe == "s")
                {
                    Console.WriteLine("Sabia que ia querer mais, é irresistivel");
                    rep = true;
                }
                if (querocafe == "n")
                {
                    Console.WriteLine("Então tá bom, espero que tenha gostado<3");
                    rep = false;
                }
            } while (rep);
        }
    }
}
