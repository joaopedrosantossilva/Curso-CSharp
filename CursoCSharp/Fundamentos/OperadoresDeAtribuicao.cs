﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresDeAtribuicao {

        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10; //num1 = num1 + 10;
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 3;
            num1 /= 5; // num1 = num1 / 3;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1
            a--; // b = b - 1 
        }
    }
}
