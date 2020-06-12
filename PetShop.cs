namespace Aula16Construtor
{
    public class PetShop
    {
        public string Raca { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Idade { get; set; }



        public PetShop(){

        }

        public PetShop(string _raca){
            
            this.Raca = _raca;
        
        }

        public PetShop(string _raca, string _descricao ){

            this.Raca      = _raca;
            this.Descricao = _descricao;

        }

        public PetShop(string _raca, string _nome, string _descricao, int _idade){

            this.Raca      = _raca;
            this.Nome      = _nome;
            this.Descricao = _descricao;
            this.Idade     = _idade;

        }
    }
}