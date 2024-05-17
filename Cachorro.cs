namespace Batata {
    public class Cachorro{
        public string NomeCachorro { get; set;}
        public string Dono { get; set;}
        public int QtdBrinquedos { get; set;}
        public bool Dormindo { get; set;}
        public int IdadeCachorro { get; set;}


        public void Apresentar(){
            Console.WriteLine($"O Nome do cachorro é {NomeCachorro}, ele (a) tem {IdadeCachorro} anos, ele(a) tem {QtdBrinquedos} brinquedos, o nome do dono é: {Dono} ");
        }

        public void Dormir(){
            Console.WriteLine("Está dormindo?.");    


        }
    }
}

    
