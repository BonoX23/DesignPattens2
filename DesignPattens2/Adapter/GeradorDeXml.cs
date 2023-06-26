using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPattens2.Adapter
{
    public class GeradorDeXml
    {
        public string GeraXml(Object objeto)
        {
            XmlSerializer serializer = new XmlSerializer(objeto.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, objeto);
            return writer.ToString();
        }
    }
}
