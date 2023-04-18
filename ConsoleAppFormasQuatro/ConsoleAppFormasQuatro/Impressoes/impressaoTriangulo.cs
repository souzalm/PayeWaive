using ConsoleAppFormasQuatro.Formatos;
using ConsoleAppFormasQuatro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFormasQuatro.Impressoes
{
    internal class impressaoTriangulo : IImpressao
    {
        public void Imprimir(Formato formato)
        {
            int n = formato.Quantidade;

            string linhaSuperior;
            string linhaInferior = "";
            List<string> linhasFinais = new List<string>();

            for (int i = 1; i <= n; i++) // Laço Inicial para todas as Formas
            {
                int m = i + (i - 1); // Tamanho da lateral superior e inferior

                for (int j = 1; j <= 1; j++) // Laço Secundário para Construção de cada Forma
                {
                    linhaSuperior = new string('*', 1);
                    string linhaSuperiorAntes = new string(' ', i - 1);
                    string linhaSuperiorDepois = new string(' ', i - 1);

                    Console.WriteLine(linhaSuperiorAntes + linhaSuperior + linhaSuperiorDepois); // Impressão da linha base

                    if (m >= 3) // Começa a adicionar a linha secundária a partir de 2 Formas
                    {
                        string linhaSecundariaUm = new string('*', 1);
                        string linhaSecundariaDois = new string(' ', 1);
                        string linhaSecundariaTres = new string('*', 1);
                        string linhaSecundariaAntes = new string(' ', i - 2);
                        string linhaSecundariaDepois = new string(' ', i - 2);
                        string linhaSecundaria = linhaSecundariaAntes + linhaSecundariaUm + linhaSecundariaDois + linhaSecundariaTres + linhaSecundariaDepois;

                        if (m >= 5)
                        {
                            linhasFinais.Add(linhaSecundaria);
                        }

                        Console.WriteLine(linhaSecundaria); // Impressão da linha secundária

                        if (m > 5) // Impressão das linhas finais intermediárias entre a linha secundária e a linha inferior
                        {
                            for (int posicao = linhasFinais.Count - 1; posicao > 0; posicao--)
                            {
                                int p = linhasFinais[posicao - 1].IndexOf("*");

                                StringBuilder stringBuilder = new StringBuilder(linhasFinais[posicao - 1]);
                                stringBuilder.Insert(p + 1, " ");
                                string linhaFinal = stringBuilder.Insert(p + 1, " ").ToString();
                                linhasFinais[posicao - 1] = linhaFinal;

                                Console.WriteLine(linhaFinal);
                            }
                        }

                        if (m >= 5)
                        {
                            int k = 1;
                            linhaInferior = "";

                            while (k <= m)
                            {
                                if (k % 2 != 0)
                                {
                                    linhaInferior = linhaInferior + new string('*', 1);
                                }
                                else
                                {
                                    linhaInferior = linhaInferior + new string(' ', 1);
                                }
                                k++;
                            }

                            Console.WriteLine(linhaInferior);
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(1000);
            }
        }
    }
}
