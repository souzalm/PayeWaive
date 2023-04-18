using ConsoleAppFormasQuatro.Formatos;
using ConsoleAppFormasQuatro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFormasQuatro.Impressora
{
    internal class Impressor
    {
        public void ImprimirFinal(Formato formato, IImpressao impressao)
        {
            impressao.Imprimir(formato);
        }
    }
}
