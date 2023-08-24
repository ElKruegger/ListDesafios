using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDesafios.Modelos
{
    public static class Pessoas
    {
        public static void listadepessoas()
        {
            List<string> pessoaslist = new List<string>() { "Pedro", "Augusto", "Josué" };
            foreach (string nomes in pessoaslist)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}
