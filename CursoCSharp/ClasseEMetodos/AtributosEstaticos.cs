using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class AtributosEstaticos {

        public class Produto {
            public string Nome;
            public double Preco;
            public static double Desconto;

            public Produto(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }

            public Produto() { }

            public double CalcularDesconto() {
                return Preco - Preco * Desconto;
            }

        }

        public static void Executar() {

            var produto1 = new Produto("Caneta", 3.2);

            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 3.5,
             };

            Produto.Desconto = 0.2;
            Console.WriteLine("Produto 1 com desconto: "+produto1.CalcularDesconto());
            Console.WriteLine("Produto 2 com desconto: "+produto2.CalcularDesconto());
    }
}
}
