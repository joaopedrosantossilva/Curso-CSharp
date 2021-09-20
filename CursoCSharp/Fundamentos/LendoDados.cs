using System;
using System.Collections.Generic;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class LendoDados {

        public static void Executar() {
            Console.WriteLine("Qual é seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é sua idade");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é seu salário? ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
