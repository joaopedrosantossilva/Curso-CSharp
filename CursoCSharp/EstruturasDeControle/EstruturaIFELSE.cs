using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIFELSE {

        public static void Executar() {
            double nota = 7.0;

            if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");
            }
            else {
                Console.WriteLine("Recuperação");
            }
        }
    }
}

