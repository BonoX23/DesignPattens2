using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Commander
{
    public class PagaPedido : IComando
    {
        private Pedido _pedido;

        public PagaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executa()
        {
            _pedido.Paga();
        }
    }
}
