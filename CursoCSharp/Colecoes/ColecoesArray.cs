using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesArray {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "joao";
            alunos[1] = "pedro";
            alunos[2] = "santos";
            alunos[3] = "silva";
            alunos[4] = "canha";

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas) {
                somatorio += nota;
           }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
