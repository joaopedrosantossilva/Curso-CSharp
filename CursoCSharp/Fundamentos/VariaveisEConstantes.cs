using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {

        public static void Executar() {

            // area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine("Area é: "+area);

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? "+estaChovendo);

            byte idade = 45;
            Console.WriteLine(idade);

            sbyte saldoDeGols = sbyte.MaxValue;
            Console.WriteLine(saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine(salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine(menorValorInt);

            uint populacaoBrasileira = 207_600_00;
            Console.WriteLine(populacaoBrasileira);

            long menorValorLong = long.MaxValue;
            Console.WriteLine(menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine(populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine(precoComputador);

            double valorDeMercadoDaApple = 100000000000.00;
            Console.WriteLine(valorDeMercadoDaApple);
        }
    }
}
