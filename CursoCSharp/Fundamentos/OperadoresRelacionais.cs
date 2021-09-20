using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {

        public static void Executar() {

            Console.WriteLine("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDecorte = 7.0;
            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota < 10.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0); //igual
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0); //diferente
            Console.WriteLine("Passou por média? {0}", nota >= notaDecorte); //Maior ou igual
        }
    }
}
