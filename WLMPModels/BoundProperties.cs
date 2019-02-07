using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace WLMPModels
{
    [XmlRoot(ElementName = "BoundProperties")]
    public class BoundProperties
    {
        [XmlElement(ElementName = "BoundPropertyInt")]
        public BoundPropertyInt BoundPropertyInt { get; set; }
        [XmlElement(ElementName = "BoundPropertyBool")]
        public List<BoundPropertyBool> BoundPropertyBool { get; set; }
        [XmlElement(ElementName = "BoundPropertyFloat")]
        public List<BoundPropertyFloat> BoundPropertyFloat { get; set; }
        [XmlElement(ElementName = "BoundPropertyFloatSet")]
        public List<BoundPropertyFloatSet> BoundPropertyFloatSet { get; set; }
        [XmlElement(ElementName = "BoundPropertyStringSet")]
        public List<BoundPropertyStringSet> BoundPropertyStringSet { get; set; }
        [XmlElement(ElementName = "BoundPropertyString")]
        public BoundPropertyString BoundPropertyString { get; set; }
    }
}
