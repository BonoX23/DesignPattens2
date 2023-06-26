using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Memento
{
    public class Contrato
    {

        public DateTime Data { get; set; }
        public string Cliente { get; set; }
        public TipoDeContrato Tipo { get; set; }

        public Contrato(DateTime data, string cliente, TipoDeContrato tipo)
        {
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }

        public void Avanca()
        {
            if (Tipo == TipoDeContrato.Novo) 
                Tipo = TipoDeContrato.EmAndamento;
            else if (Tipo == TipoDeContrato.EmAndamento) 
                Tipo = TipoDeContrato.Acertado;
            else if (Tipo == TipoDeContrato.Acertado) 
                Tipo = TipoDeContrato.Concluido;
        }

        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(Data, Cliente, Tipo));
        }

        public void Restaura(Estado estado)
        {
            Data = estado.Contrato.Data;
            Cliente = estado.Contrato.Cliente;
            Tipo = estado.Contrato.Tipo;    
        }


    }
}
