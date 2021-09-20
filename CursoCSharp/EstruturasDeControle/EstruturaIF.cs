using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIF {

        public static void Executar() {

            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento? (S/N): ");
            entrada = Console.ReadLine();

            var bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra");
            }
            
           
        }
    }
}
