using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ColecoesSet {

        public static void Executar() {
            var livro = new Produto("Game of Thrones", 4.8);
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Bola", 4.5),
                new Produto("Ultima temporada game of thrones", 5.0)
            };

            carrinho.UnionWith(combo); //adiciona varios itens a uma lista.
            Console.WriteLine(carrinho.Count); //conta quantos itens tem na lista

            foreach(var item in carrinho) {
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
        }
    }
}
