using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class SubCelebridade {

        //todos
        public string InfoPublica = "Tenho um instagram!";

        //herença
        protected string CorDoOlho = "Verde";

        //mesmo projeto(assembly)
        internal ulong NumeroCelular = 551199999999;

        //herença ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muito gírias";

        //mesma class ou herença no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        //private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
