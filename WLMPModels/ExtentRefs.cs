using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace WLMPModels
{
    [XmlRoot(ElementName = "ExtentRefs")]
    public class ExtentRefs
    {
        [XmlElement(ElementName = "ExtentRef")]
        public List<ExtentRef> ExtentRef { get; set; }
    }
}
