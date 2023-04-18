using ConsoleAppFormasQuatro.Formatos;
using ConsoleAppFormasQuatro.Impressoes;
using ConsoleAppFormasQuatro.Impressora;
using ConsoleAppFormasQuatro.Suporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppFormasQuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sair sair;

            while (true)
            {
                Console.WriteLine("Qual o formato que deseja imprimir? (Escolha entre: Triângulo, Quadrado, Retângulo, Losango e Hexágono). " +
                    "Se desejar sair do console e encerrar o programa, digite SAIR.");
                Console.WriteLine();

                string? forma = Console.ReadLine();
                Console.WriteLine();

                sair = new Sair(forma);
                sair.Desligar();

                Console.WriteLine("Quantas repetições do formato deseja que seja apresentado? Digite um número inteiro, a partir de 1. " +
                    "Se desejar sair do console e encerrar o programa, digite SAIR.");
                Console.WriteLine();

                string? quantidadeString = Console.ReadLine();
                Console.WriteLine();

                sair = new Sair(quantidadeString);
                sair.Desligar();

                int quantidade = int.Parse(quantidadeString);

                var impressora = new Impressor();

                var formato = new Formato(forma, quantidade);

                switch (formato.Forma.ToUpper())
                {
                    case "TRIÂNGULO":
                        impressora.ImprimirFinal(formato, new impressaoTriangulo());
                        break;
                    case "QUADRADO":
                        impressora.ImprimirFinal(formato, new impressaoQuadrado());
                        break;
                    case "RETÂNGULO":
                        impressora.ImprimirFinal(formato, new impressaoRetangulo());
                        break;
                    case "LOSANGO":
                        impressora.ImprimirFinal(formato, new impressaoLosango());
                        break;
                    case "HEXÁGONO":
                        impressora.ImprimirFinal(formato, new impressaoHexagono());
                        break;
                    default:
                        Console.WriteLine("Você não digitou corretamento o formato ou a quantidade!");
                        break;

                }
            }
        }
    }
}
