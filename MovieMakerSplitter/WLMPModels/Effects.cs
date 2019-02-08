using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "Effects")]
    public class Effects
    {
        [XmlElement(ElementName = "TextEffect")]
        public TextEffect TextEffect { get; set; }
    }
}
