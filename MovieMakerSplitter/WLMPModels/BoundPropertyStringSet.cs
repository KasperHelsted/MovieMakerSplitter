using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "BoundPropertyStringSet")]
    public class BoundPropertyStringSet
    {
        [XmlElement(ElementName = "BoundPropertyStringElement")]
        public List<BoundPropertyStringElement> BoundPropertyStringElement { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }
}
