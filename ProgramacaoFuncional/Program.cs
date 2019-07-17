using System;
using System.Collections.Generic;
using ProgramacaoFuncional.Entidades;

namespace ProgramacaoFuncional
{
    class Program
    {
        public static int ValorGlobal = 3;
        static void Main(string[] args)
        {
            /*
            var produtos = new List<Produto>();

            produtos.Add(new Produto("TV", 900.00));
            produtos.Add(new Produto("Notebook", 1200.00));
            produtos.Add(new Produto("Tablet", 450.00));

            //Comparison<Produto> comp = CompararProdutos;
            Comparison<Produto> comp = (p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToString());

            produtos.Sort(comp);
            
            foreach(var produto in produtos){
                Console.WriteLine(produto);
            }
            */

            int[] vetor = new int[] {3, 4, 5};
            ChangeOddValues(vetor);
            System.Console.WriteLine(string.Join(" ", vetor));
        }
        
        static int CompararProdutos(Produto p1, Produto p2){
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToString());
        }

        static void ChangeOddValues(int[] numeros){
            for(int i = 0; i< numeros.Length; i++){
                if(numeros[i] % 2 != 0){
                    numeros[i] += ValorGlobal;
                }
            }
        }

    }
}
