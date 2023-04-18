using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFormasQuatro.Formatos
{
    internal class Formato
    {
        // Possibilidades de Forma: Triângulo, Quadrado, Retângulo, Losango e Hexágono
        public string Forma { get; set; }
        public int Quantidade { get; set; }

        public Formato(string forma, int quantidade)
        {
            Forma = forma;
            Quantidade = quantidade;
        }
    }
}
