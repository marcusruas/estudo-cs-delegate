using System;
using System.Collections.Generic;
using Derivados.Entidades;
using System.Linq;

namespace Derivados
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtos = new List<Produto>();

            produtos.Add(new Produto("TV", 900.00));
            produtos.Add(new Produto("Mouse", 50.00));
            produtos.Add(new Produto("Tablet", 350.50));
            produtos.Add(new Produto("HD Case", 80.90));

            /*Exemplo de Predicate, que recebe como argumento um objeto T e retorna um Booleano

            //produtos.RemoveAll(p => p.Preco > 100);
            produtos.RemoveAll(TestarProdutoPredicate);
            
            */

            /*Exemplo de Action, que é um método void para alteração que recebe até 16 parâmetros
                
                //Action<Produto> act = p => {p.Preco += p.Preco * 0.1;}
                Action<Produto> act = UpdatePreco;
                produtos.ForEach(act);
                //produtos.ForEach(UpdatePreco);

            */

            /*Exemplo de Func, que recebe até 16 parametros e retorna algo
                
                //Func<Produto, string> func = NomeUpper;
                Func<Produto, string func = p => p.Nome.ToUpper();
                
                //var result = produtos.Select(NomeUpper).ToList();
                var result = produtos.Select(func).ToList();

                foreach(string s in result){
                    Console.WriteLine(s);
                }

            */

            

            foreach(Produto p in produtos){
                Console.WriteLine(p);
            }
        }
        public static bool TestarProdutoPredicate(Produto p){
            return p.Preco >= 100;
        }

        public static void UpdatePreco(Produto p){
            p.Preco += p.Preco * 0.1;
        }

        public static string NomeUpper(Produto p){
            return p.Nome.ToUpper();
        }
    }
}
