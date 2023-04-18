using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFormasQuatro.Suporte
{
    internal class Sair
    {
        private string? Texto { get; set; }

        public Sair(string? texto)
        {
            Texto = texto;
        }
        public void Desligar()
        {
            if (Texto == null || Texto.ToUpper().Equals("SAIR") || Texto.Trim().Equals(""))
            {
                Environment.Exit(0);
            }
        }
    }
}
