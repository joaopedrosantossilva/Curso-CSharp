using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class Membros {

        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "João Pedro";
            sicrano.Idade = 18;

            sicrano.ApresentarNoConsole();
        }
    }
}
 