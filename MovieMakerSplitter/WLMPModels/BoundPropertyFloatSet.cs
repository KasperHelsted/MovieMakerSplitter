using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "BoundPropertyFloatSet")]
    public class BoundPropertyFloatSet
    {
        [XmlElement(ElementName = "BoundPropertyFloatElement")]
        public List<BoundPropertyFloatElement> BoundPropertyFloatElement { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }
}
