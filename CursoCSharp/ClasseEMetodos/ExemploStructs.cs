using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    interface Ponto {
        void MoverNaDiogonal(int delta);
    }

    struct Coordenada: Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            Y = y;
            X = x; 
        }

        public void MoverNaDiogonal(int delta) {
            X += delta;
            Y += delta;
        }
    }

    class ExemploStructs {

        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;
            Console.WriteLine("Cordenada inicial: ");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("X = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiogonal(10);
            Console.WriteLine("Cordenada Final: ");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("X = {0}", coordenadaFinal.Y);
        }
    }
}
