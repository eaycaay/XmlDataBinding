using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlDataBinding.Model
{
    [XmlRoot("Data")]
    public class Data
    {
        [XmlElement("DataName")]
        public string DataName { get; set; }

        [XmlArray("Data List")]
        [XmlArrayItem("Data Item")]
        public List<DataItem> DataList { get; set; }
    }
}
