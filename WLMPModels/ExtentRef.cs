using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace WLMPModels
{
    [XmlRoot(ElementName = "ExtentRef")]
    public class ExtentRef
    {
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }
    }
}
