using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Commander
{
    public class FilaDeTrabalho
    {
        private IList<IComando> comandos = new List<IComando>();
        public void Adicionar(IComando comando)
        {
            comandos.Add(comando);
        }

        public void Procesa()
        {
            foreach (IComando comando in comandos)
            {
                comando.Executa();
            }
        }
    }
}
