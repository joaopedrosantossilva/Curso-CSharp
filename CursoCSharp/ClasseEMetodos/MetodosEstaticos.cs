using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class MetodosEstaticos {

        public class CalculadoraEstatica { 
            public static int Somar(int a, int b) {
                return a + b;
            }

            public static int Multiplicar(int a, int b) {
                return a * b;
            }
        }

        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(3, 2);
        }
    }
}
