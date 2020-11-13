using System;

namespace exe._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano que você nasceu");
            int ano=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual");
            int atualAno=int.Parse(Console.ReadLine());
            int nascimento=atualAno-ano;
            double semanas=nascimento*52.1426; //Um ano tem 52,1429 semanas
            Console.WriteLine("Idade dessa pessoa é "+nascimento+" anos");            
            Console.WriteLine("Essa idade convertida em semana é "+semanas+" semanas");
        }
    }
}
