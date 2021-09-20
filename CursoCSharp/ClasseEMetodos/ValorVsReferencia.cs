using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    public class Dependente {
        public string Nome;
        public int Idade;
    }


    class ValorVsReferencia {

        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            numero++;
            Console.WriteLine(numero);
            Console.WriteLine(copiaNumero);

            Dependente dep = new Dependente();
            dep.Nome = "Beto";
            dep.Idade = 20;

            var copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 21;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}
