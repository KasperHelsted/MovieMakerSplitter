using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace WLMPModels
{
    [XmlRoot(ElementName = "Effects")]
    public class Effects
    {
        [XmlElement(ElementName = "TextEffect")]
        public TextEffect TextEffect { get; set; }
    }
}
