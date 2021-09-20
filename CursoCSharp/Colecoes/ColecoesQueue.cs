using System;
using System.Collections.Generic;
using System.Collections; 

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {

        public static void Executar() {

            var fila = new Queue<string>();
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var nome in fila) {
                Console.WriteLine(nome);
            }
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("item");
        }
    }
}
