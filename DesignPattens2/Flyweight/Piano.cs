using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Flyweight
{
    public class Piano
    {
        public void Toca(IList<INotas> musica)
        {
            foreach (var nota in musica)
            {
                Console.Beep(nota.Frequencia, 150);
            }

        }
    }
}
