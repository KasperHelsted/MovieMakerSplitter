using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "BoundPropertyFloatElement")]
    public class BoundPropertyFloatElement
    {
        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
    }
}
