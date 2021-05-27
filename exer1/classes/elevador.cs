using System;

namespace exer1.classes
{
    public abstract class elevador
    {
        public int andaratual;

        public int totalpessoas = 1;

        protected int totalandares;

        protected int capacidade;

        protected int pessoas;

        public void infos(int totalandares, int capacidade)
        {
            Console.WriteLine("Quantos andares tem o prédio? (contando o terreo)");
            totalandares = int.Parse(Console.ReadLine());

            Console.Write("Qual é a capacidade do elevador?");
            capacidade = int.Parse(Console.ReadLine());
        }

        public void inicializa(int totalandares, int capacidade)
        {
        }

        public void entrar(int capacidade, int totalpessoas)
        {
            Console.WriteLine("Digite o numero de pessoas que entrou nesse andar");
            int pessoas = int.Parse(Console.ReadLine());

            totalpessoas = totalpessoas + pessoas;

            if (totalpessoas <= capacidade)
            {
                Console.WriteLine("As pessoas entraram normalmente no elevador");
            }
            else if (totalpessoas >= capacidade)
            {

            }
            Console.WriteLine($"O novo total de pessoas no elevador com você é: {totalpessoas}");
        }
        public void sair(int capacidade, int totalpessoas)
        {
            Console.WriteLine("Digite o numero de pessoas que sairam nesse andar");
            int pessoas = int.Parse(Console.ReadLine());

            totalpessoas = totalpessoas + pessoas;

            Console.WriteLine($"O novo total de pessoas no elevador com você é: {totalpessoas}");
        }
        public void subir()
        {    
            Console.WriteLine("Quantos andares deseja subir?");
            int subir = int.Parse(Console.ReadLine());

            for (var i = 0; i < subir; i++)
            {
                entrar(capacidade, totalpessoas);
                sair(capacidade, totalpessoas);
            }
        }
        public void descer()
        {

        }
    }
}