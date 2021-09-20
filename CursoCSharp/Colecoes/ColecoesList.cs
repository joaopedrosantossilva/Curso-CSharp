using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {


    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }
    }

    class ColecoesList {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 4.8);
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Bola", 4.5),
                new Produto("Ultima temporada game of thrones", 5.0)
            };

            carrinho.AddRange(combo); //adiciona varios itens a uma lista.
            Console.WriteLine(carrinho.Count); //conta quantos itens tem na lista
            carrinho.RemoveAt(3); //remove item da posicao 3

            foreach(var item in carrinho) {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
        }
    }
}
