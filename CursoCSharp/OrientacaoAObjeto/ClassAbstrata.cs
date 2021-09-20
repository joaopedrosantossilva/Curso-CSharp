﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoAObjeto {

    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {

            return "Trim trim trim trim...";
                }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá! meu nome é bixby!";
        }
    }

    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá. meu nome é siri!";
        }
    }

    class ClassAbstrata {

        public static void Executar() {
            var celulares = new List<Celular> {
                new Iphone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine($"{celular.Assistente()}");
            }
        }
    }
}
