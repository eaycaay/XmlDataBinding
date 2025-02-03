using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XmlDataBinding.Model;

namespace XmlDataBinding.Common
{
    public class XmlHelper
    {
        
        public static void SerializeToXml(Data data, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Data));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static Data DeserializeFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Data));
            using (TextReader reader = new StreamReader(filePath))
            {
                return (Data)serializer.Deserialize(reader);
            }
        }
        
    }
}
