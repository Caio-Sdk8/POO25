using System;
namespace polimorfismo.classes
{
    public class maquinaCafe
    {
        public int AcucarDisp{get; set;}

        public int quantidade{set; get;}

        public void FazerCafé(int AcucarDisp){
            Console.WriteLine("Qual a quantidade que você deseja em seu café?");
            quantidade = int.Parse(Console.ReadLine());
            
            if (AcucarDisp >= quantidade)
            {
                Console.WriteLine($"Tome seu cafézinho com {quantidade}g de açucar, melhor café do mundo by Tabajara Plus+.");
            }
            else
            {
                Console.WriteLine("Desculpe, o valor inserido não é possivel, a maquina não tem o açucar necessário.");
                Console.WriteLine("Aceitas um sem açucar? s-sim    n-não");
                string resp2 = Console.ReadLine().ToLower();

                if (resp2 == "s")
                {
                   Console.WriteLine($"Então tome seu cafézinho sem açucar, melhor café do mundo by Tabajara Plus+."); 
                }else if(resp2 == "n"){
                    Console.WriteLine("Ok, não queria fazer mesmo");
                }
            }
        }
        public void FazerCafé(){
            quantidade = 10;
            if (AcucarDisp >= quantidade){
             Console.WriteLine($"Tome seu cafézinho com {quantidade}g de açucar, melhor café do mundo by Tabajara Plus+.");
            }else
            {
                Console.WriteLine("Desculpe, o valor inserido não é possivel, a maquina não tem o açucar necessário.");
                Console.WriteLine("Aceitas um sem açucar? s-sim    n-não");
                string resp2 = Console.ReadLine().ToLower();

                if (resp2 == "s")
                {
                   Console.WriteLine($"Então tome seu cafézinho sem açucar, melhor café do mundo by Tabajara Plus+."); 
                }else if(resp2 == "n"){
                    Console.WriteLine("Ok, não queria fazer mesmo");
                }
            }
        }
    }
}