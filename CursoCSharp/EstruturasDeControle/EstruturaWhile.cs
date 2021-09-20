using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaWhile {

        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestantes = 5;
            int tentativas = 0;

            while (tentativaRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira o seu palpite: ");
                string Entrada = Console.ReadLine();
                int.TryParse(Entrada, out palpite);
                tentativas++;
                tentativaRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto) {
                    Console.WriteLine("Numero menor... ");
                    if (tentativaRestantes == 0) {
                        Console.WriteLine("Tentativas encerradas!");
                    }
                    else{ 
                        Console.WriteLine("tente novamente! Tentativa restantes: " + tentativaRestantes);
                    }
                }
                else {
                    Console.WriteLine("Numero maior... ");
                    if (tentativaRestantes == 0) {
                        Console.WriteLine("Tentativas encerradas!");
                    }
                    else {
                        Console.WriteLine("tente novamente! Tentativa restantes: " + tentativaRestantes);
                    }
                    }
            }

        }
    }
}
