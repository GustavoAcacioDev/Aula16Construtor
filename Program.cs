using System;

namespace Aula16Construtor
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instancia sem nenhum argumento
            PetShop gato = new PetShop();
            gato.Nome = "Jade";
            System.Console.WriteLine("Nome: "+gato.Nome);

            System.Console.WriteLine("--------------------------------------------");

            //Instancia com 1 argumento
            PetShop gatinho = new PetShop("Sphynx");
            System.Console.WriteLine("Raça: "+gatinho.Raca);

            System.Console.WriteLine("--------------------------------------------");

            //Instancia com 2 argumentos
            PetShop cachorro = new PetShop("Shih Tzu", "Tosa higiênica");
            System.Console.WriteLine("Raça: "+cachorro.Raca);
            System.Console.WriteLine("Descrição do banho: "+cachorro.Descricao);

            System.Console.WriteLine("--------------------------------------------");

            //Instancia com 4 argumentos
            PetShop cachorrinho = new PetShop("Doberman", "Halley", "Tosa", 8);
            System.Console.WriteLine("Raça: "+cachorrinho.Raca);
            System.Console.WriteLine("Nome: "+cachorrinho.Nome);
            System.Console.WriteLine("Descrição do banho: "+cachorrinho.Descricao);
            System.Console.WriteLine("Idade: "+cachorrinho.Idade+" anos");
        }
    }
}
