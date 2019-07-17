namespace Linq.Entidades {
    public class Produto {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categoria categoria { get; set; }

        public override string ToString(){
            return "ID: "+Id+
            "\nNome: "+Nome+
            "\nPreço: R$"+Preco.ToString("F2")+
            "\nCategoria: "+categoria.Nome+", Tier: "+categoria.Tier;
        }
    }
}