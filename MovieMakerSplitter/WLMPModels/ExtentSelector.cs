using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "ExtentSelector")]
    public class ExtentSelector
    {
        [XmlElement(ElementName = "Effects")]
        public string Effects { get; set; }

        [XmlElement(ElementName = "Transitions")]
        public string Transitions { get; set; }

        [XmlElement(ElementName = "BoundProperties")]
        public string BoundProperties { get; set; }

        [XmlElement(ElementName = "ExtentRefs")]
        public ExtentRefs ExtentRefs { get; set; }

        [XmlAttribute(AttributeName = "extentID")]
        public int ExtentID { get; set; }

        [XmlAttribute(AttributeName = "gapBefore")]
        public double GapBefore { get; set; }

        [XmlAttribute(AttributeName = "primaryTrack")]
        public string PrimaryTrack { get; set; }
    }
}
