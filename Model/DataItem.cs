using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlDataBinding.Model
{
    public class DataItem
    {
        [XmlElement("FirstProperty")]
        public int FirstProperty { get; set; }

        [XmlElement("SecondProperty")]
        public string SecondProperty { get; set; }

        [XmlElement("ThirdProperty")]
        public string ThirdProperty {get; set; }

    }
}
