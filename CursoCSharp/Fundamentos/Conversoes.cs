using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {

        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(inteiro);

            double nota = 9.7;
            int notaTruncada = (int) nota; //Truncando a nota utilizando o cast, ou seja, corta as casas decimais. 
            Console.WriteLine("O valor da nota truncada é: " + notaTruncada);

            Console.WriteLine("Digite sua idadE: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.WriteLine("Digite um número");
            String palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);

            Console.WriteLine("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int numero2);


        }
    }
}
