using System;
using exer2.classes;

namespace exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rep = false;

            Console.WriteLine(@"Qual a faixa do campo em que o jogador que você deseja cadastrar joga?
            Sendo opções: Meio, Defesa, Ataque.");
            string posicao = Console.ReadLine().ToLower();


            switch (posicao)
            {
                case "defesa":

                    jogadordef varane = new jogadordef();
                    varane.cadas();

                    do
                    {
                        Console.WriteLine(@"O que deseja fazer agora?
                ________________________________________
                |  1- Listar minhas informações        |
                |  2- Dizer quando devo me aposentar   |
                |  0- Sair                             |
                ----------------------------------------");
                        int menu = int.Parse(Console.ReadLine());

                        switch (menu)
                        {
                            case 1:
                                varane.idadejg();
                                varane.listagem();
                                rep = true;
                                break;
                            case 2:
                                varane.idadejg();
                                varane.aposentado();
                                rep = true;
                                break;
                            case 0:
                                Console.WriteLine("Adeus, foi bom ser um terminal, espero que eu tenha sido util");
                                rep = false;
                                break;
                            default:
                                break;
                        }
                    } while (rep);

                    break;
                case "meio":
                    jogadormeia iniesta = new jogadormeia();
                    iniesta.cadas();

                    do
                    {
                        Console.WriteLine(@"O que deseja fazer agora?
                ________________________________________
                |  1- Listar minhas informações        |
                |  2- Dizer quando devo me aposentar   |
                |  0- Sair                             |
                ----------------------------------------");
                        int menu = int.Parse(Console.ReadLine());
                        switch (menu)
                        {
                            case 1:
                                iniesta.idadejg();
                                iniesta.listagem();
                                rep = true;
                                break;
                            case 2:
                                iniesta.idadejg();
                                iniesta.aposentado();
                                rep = true;
                                break;
                            case 0:
                                Console.WriteLine("Adeus, foi bom ser um terminal, espero que eu tenha sido util");
                                rep = false;
                                break;
                            default:
                                break;
                        }
                    } while (rep);
                    break;
                case "ataque":
                    jogaataque neymar = new jogaataque();
                    neymar.cadas();

                    do
                    {
                        Console.WriteLine(@"O que deseja fazer agora?
                ________________________________________
                |  1- Listar minhas informações        |
                |  2- Dizer quando devo me aposentar   |
                |  0- Sair                             |
                ----------------------------------------");
                        int menuzada = int.Parse(Console.ReadLine());
                        switch (menuzada)
                        {
                            case 1:
                                neymar.idadejg();
                                neymar.listagem();
                                rep = true;
                                break;
                            case 2:
                                neymar.idadejg();
                                neymar.aposentado();
                                rep = true;
                                break;
                            case 0:
                                Console.WriteLine("Adeus, foi bom ser um terminal, espero que eu tenha sido util");
                                rep = false;
                                break;
                            default:
                                break;
                        }
                    } while (rep);
                    break;
                default:
                    break;
            }

        }
    }
}