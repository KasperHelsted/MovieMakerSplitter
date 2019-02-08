using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "BoundPropertyStringElement")]
    public class BoundPropertyStringElement
    {
        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
    }
}
