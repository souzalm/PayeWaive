using ConsoleAppFormasQuatro.Formatos;
using ConsoleAppFormasQuatro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFormasQuatro.Impressoes
{
    internal class impressaoQuadrado : IImpressao
    {
        // O código de fato para implementação dessa variação seria específico, por a necessidade de se criar uma classe específica
        public void Imprimir(Formato formato)
        {
            Console.WriteLine($"O formato escolhido é {formato.Forma} e a quantidade de repetições que deseja imprimir é {formato.Quantidade}.");
            Console.WriteLine();
        }
    }
}
