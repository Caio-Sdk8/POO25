using System;

namespace exer2.classes
{
    public abstract class jogador
    {
        private int datanasc
        {
            get;
            set;
        }

        private string nome
        {
            get;
            set;
        }

        private string nacionalidade
        {
            get;
            set;
        }

        private string peso
        {
            get;
            set;
        }

        private string altura
        {
            get;
            set;
        }

        virtual protected int aposentar
        {
            get;
            set;
        }

        protected int idade{
            get;
            set;
        }

        public void cadas(){
            Console.WriteLine("Qual  teu nome?");
            nome = Console.ReadLine();
            
            Console.WriteLine("qual o ano em que você nasceu?");
            datanasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Me diga sua altura:");
            altura = Console.ReadLine();

            Console.WriteLine("Qual o seu peso?");
            peso = Console.ReadLine();

            Console.WriteLine("Qual a sua nacionalidade?");
            nacionalidade = Console.ReadLine();
        }

        public int idadejg()
        {
            idade = (DateTime.Now.Year - datanasc);

            return idade;
        }

        virtual public void aposentado()
        {
            if (idade < aposentar)
            {
                Console.WriteLine($"já que você tem a idade de {idade} você deve se aposentar daqui a {(aposentar - idade)}");
            }
            else if (idade == aposentar)
            {
                Console.WriteLine("Você deveria se aposentar agora velhinho");
            }else if (idade > aposentar)
            {
                Console.WriteLine("Você já deveria ter se aposentado meu bom");
            }
        }
        public void listagem()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine($"Nacionalidade: {nacionalidade}");
        }
    }
}