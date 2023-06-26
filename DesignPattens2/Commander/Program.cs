using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Commander
{
    public class Program
    {
        static void Main(String[] args)
        {
            Pedido pedido1 = new Pedido("Mauricio", 150.0);
            Pedido pedido2 = new Pedido("Marcelo", 250.0);

            FilaDeTrabalho fila = new FilaDeTrabalho();

            fila.Adicionar(new PagaPedido(pedido1));
            fila.Adicionar(new PagaPedido(pedido2));
            fila.Adicionar(new FinalizaPedido(pedido1));

            fila.Procesa();
        }
    }
}
