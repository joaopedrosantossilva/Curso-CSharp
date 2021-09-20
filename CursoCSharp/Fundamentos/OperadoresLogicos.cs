using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {

        public static void Executar() {

            var executouTrabalho1 = true;
            var executouTrabalho2 = true;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2; // as duas expressões precisam ser verdadeiras
            Console.WriteLine("Comprou TV de 50 polegadas? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // ou, ou seja, ao menos uma das opções precisa ser verdadeira
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; //ou exclusivo, ou seja, so pode uma das opções serem verdadeiras
            Console.WriteLine("Comprou a tv de 32? {0}", comprouTv32);

        }
    }
}
