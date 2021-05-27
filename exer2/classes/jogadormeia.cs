using System;
namespace exer2.classes
{
    public class jogadormeia : jogador
    {
        public override void aposentado()
        {
            aposentar = 38;
             if (idade < 38)
            {
                Console.WriteLine($"já que você tem a idade de {idade} anos você deve se aposentar daqui a  por volta de {(aposentar - idade)} anos");
            }
            else if (idade == 38)
            {
                Console.WriteLine("Você deveria se aposentar agora velhinho");
            }else if (idade > 38)
            {
                Console.WriteLine("Você já deveria ter se aposentado meu bom");
            }
        }
    }
}