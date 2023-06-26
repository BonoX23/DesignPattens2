using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Adapter
{
    public class Program
    {
        static void Main(String[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            String xml = new GeradorDeXml().GeraXml(cliente);
            Console.WriteLine(xml);
        }
    }
}
