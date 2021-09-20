using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresTenarios {

        public static void Executar() { 

            var nota = 7.0;
            var resultado = nota >= 7.0 ? "Aprovado":"Reprovado"; // expressão ? operando:operando;
            Console.WriteLine(resultado);
        }
    }
}
