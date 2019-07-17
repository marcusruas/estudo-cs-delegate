using System;
using System.Linq;
using Linq.Entidades;
using System.Collections.Generic;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Categoria cat1 = new Categoria() { Id = 1, Nome = "Ferramentas", Tier = 2};
            Categoria cat2 = new Categoria() { Id = 2, Nome = "Computadores", Tier = 1};
            Categoria cat3 = new Categoria() { Id = 3, Nome = "Eletrônicos", Tier = 1};

            List<Produto> produtos = new List<Produto>(){
                new Produto() { Id = 1, Nome = "Computador", Preco = 1100.00, categoria = cat2},
                new Produto() { Id = 2, Nome = "Martelo", Preco = 90.00, categoria = cat1},
                new Produto() { Id = 3, Nome = "TV", Preco = 1700.00, categoria = cat3},
                new Produto() { Id = 4, Nome = "NoteBook", Preco = 1300.00, categoria = cat2},
                new Produto() { Id = 5, Nome = "Serra", Preco = 80.00, categoria = cat1},
                new Produto() { Id = 6, Nome = "Tablet", Preco = 700.00, categoria = cat2},
                new Produto() { Id = 7, Nome = "Camera", Preco = 700.00, categoria = cat3},
                new Produto() { Id = 8, Nome = "Impressora", Preco = 350.00, categoria = cat3},
                new Produto() { Id = 9, Nome = "MacBook", Preco = 1800.00, categoria = cat2},
                new Produto() { Id = 10, Nome = "SoundBar", Preco = 700.00, categoria = cat3},
                new Produto() { Id = 11, Nome = "Level", Preco = 70.00, categoria = cat1}
            };
            
            /* Introdução
            //especificar data source
            int[] numeros = new int[]{1,2,3,4,5,6};
            //define a query
            var result = numeros.Where(n => n % 2 == 0).Select(RetornarNumeros);
            foreach(int numero in result){
                Console.WriteLine(numero);
            }
            */
            
            /* Funções Linq 
            //var produtos_filtrados = produtos.Where(p => p.Preco < 900 && p.categoria.Tier == 1);
            var produtos_filtrados = from p in produtos where p.Preco < 900 && p.categoria.Tier == 1 select p;//notação SQL
            Print("Produtos de Primeira mão e Preço menor que 900.00", produtos_filtrados);
            //Select = projeção, selecionar campos
            //var produtos_ferramentas = produtos.Where(p => p.categoria.Nome == "Ferramentas").Select(p => p.Nome);
            var produtos_ferramentas = from p in produtos where p.categoria.Nome == "Ferramentas" select p.Nome;
            Print("Nomes dos Produtos da Categoria \"Ferramentas\"", produtos_ferramentas);
            //Objeto anônimo
            var produtos_c = produtos.Where(p => p.Nome[0] == 'c').Select(p => new {p.Nome, p.Preco, categorianome = p.categoria.Nome});
            Print("Produtos com a letra C (Somente o nome, o preço e o nome da categoria)", produtos_c);
            //Ordernar por Preço então por nome
            var ordenados = produtos.OrderBy(p => p.Preco).ThenBy(p => p.Nome);
            Print("Produtos Ordernados por Preço", ordenados);
            //Skip pega 4 elementos pulando os 2 primeiros
            var pulados = ordenados.Skip(2).Take(4);
            Print("Pula 2 pega o quarto", pulados);
            //Pegar Primeiro, se não tiver retorna Nulo, pode usar single tbm
            var primeiro = produtos.FirstOrDefault();
            
            //Produto maximo por preço (sem criterio comp. vai dar exceção)
            var produto_maximo = produtos.Max(p => p.Preco);
            System.Console.WriteLine(produto_maximo);
            //Soma dos Produtos
            var soma_produto = produtos.Sum(p => p.Preco);
            //PARA TRATAR EXCEÇÃO
            var padraosenulo = produtos.Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            System.Console.WriteLine(padraosenulo);
            //agreggate
            var mapreduce = produtos.Where(p => p.categoria.Tier == 1).Select(p => p.Preco).Aggregate(0.0, (x,y) => x + y);
            System.Console.WriteLine(mapreduce);
            //groupby
            var agrupamentos = produtos.GroupBy(p => p.categoria.Tier);
            foreach(IGrouping<Categoria, Produto> grupo in agrupamentos){
                Console.WriteLine(grupo.Key.Nome+": ");
                foreach(Produto p in grupo){
                    System.Console.WriteLine(p);
                }
            }
            */

            /* Algebra SQL */

        }
        public static int RetornarNumeros(int n){
            return n * 10;
        }
        public static void Print<T>(string mensagem, IEnumerable<T> lista){
            Console.WriteLine(mensagem);
            foreach(T obj in lista){
                Console.WriteLine(obj);
            }
        }
    }
}
