using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {

        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));    // Valor com uma casa decimal
            Console.WriteLine(valor.ToString("C"));     // Exibe o valor monetário de acordo com a moeda do sistema operacional
            Console.WriteLine(valor.ToString("P"));     // Exibe o valor em percentual
            Console.WriteLine(valor.ToString("#.##"));  // Valor exibido com duas casas decimais

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura)); //valor exibido em real, sem casas decimais, na linguagem pt-BR

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //inclui zeros na frente do numero, até ele ficar com 10 posições
     
        }
    }
}
