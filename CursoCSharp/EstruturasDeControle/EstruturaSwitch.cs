using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaSwitch {

        public static void Executar() {

            Console.WriteLine("Informe uma avaliacao de 1 a 5");
            string entrada = Console.ReadLine();

            int.TryParse(entrada, out int saida);

            switch (saida) {
                case 0:
                    Console.WriteLine("Pessimo");
                    break;
                case 1:
                    Console.WriteLine("Muito ruim");
                    break;
                case 2:
                    Console.WriteLine("ruim");
                    break;
                case 3:
                    Console.WriteLine("bom");
                    break;
                 case 4:
                    Console.WriteLine("muito bom");
                    break;
                case 5:
                    Console.WriteLine("otimo");
                    break;
                default:
                    Console.WriteLine("Nota invalida");
                    break;

            }

            Console.WriteLine("Fim do swith");
        }
    }
}
