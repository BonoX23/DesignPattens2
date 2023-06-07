using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Flyweight
{
    public class NotasMusicais
    {
        private static IDictionary<string, INotas> notas = new Dictionary<string, INotas>()
        {
            { "do", new Do() },
            { "re", new Re() },
            { "mi", new Mi() },
            { "fa", new Fa() },
            { "sol", new Sol() },
            { "la", new La() },
            { "si", new Si() },
        };
        public INotas Pega(string nome)
        {
            return notas[nome];
        }
    }
}
