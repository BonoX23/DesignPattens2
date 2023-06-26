using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Commander
{
    public class Pedido
    {

        public string Cliente { get; set; }
        public double Valor { get; set; }
        public Status Status { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public Pedido(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
            Status = Status.Novo;
        }

        public void Paga()
        {
            Status = Status.Pago;
        }

        public void Finaliza()
        {
            DataFinalizacao = DateTime.Now;
            Status = Status.Entregue;
        }


    }
}
