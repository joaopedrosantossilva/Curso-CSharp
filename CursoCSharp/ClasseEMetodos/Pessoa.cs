using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format($"Hello! My name is {Nome} and I have a {Idade}years old");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome ="";
            Idade = 0;
        }

    }
}
