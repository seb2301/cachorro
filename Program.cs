using System.Net.Http.Headers;

namespace Batata
{
    public class Program3
    {
        static void Main()
        {
            Cachorro cachorro = new Cachorro();

            Console.WriteLine("Informe o nome do seu cachorro: ");
            cachorro.NomeCachorro = Console.ReadLine() ?? "";

            Console.WriteLine("Informe idade do seu cachorro: ");
            cachorro.IdadeCachorro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do dono do cachorro: ");
            cachorro.Dono = Console.ReadLine() ?? "";

            Console.WriteLine("Informe a quantidade de brinquedos: ");
            cachorro.QtdBrinquedos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O cachorro está dormindo?: ");
            cachorro.Dormindo = Convert.ToBoolean(Console.ReadLine());



            Cachorro[] Cachorro = new Cachorro[2];

            for (int i = 0; i <= 1; i++)
            {
                Cachorro[i] = new Cachorro();

                Console.WriteLine("Informe o nome do cachorro: ");
                Cachorro[i].NomeCachorro = Console.ReadLine() ?? "";

                Console.WriteLine("Informe a idade do cachorro: ");
                Cachorro[i].IdadeCachorro = Convert.ToInt32(Console.ReadLine());
            }

            Cachorro[0].Apresentar();

        }
    }
}
