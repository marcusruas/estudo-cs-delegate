namespace ProgramacaoFuncional.Entidades
{
    public class Produto
    {
        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
        }
        
        public string Nome { get; set; }
        public double Preco { get; set; }

        public override string ToString(){
            return "Nome: "+Nome+", Preço: R$"+Preco.ToString("F2");
        }
    }
}