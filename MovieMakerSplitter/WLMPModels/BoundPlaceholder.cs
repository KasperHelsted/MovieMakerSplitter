using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "BoundPlaceholder")]
    public class BoundPlaceholder
    {
        [XmlAttribute(AttributeName = "placeholderID")]
        public string PlaceholderID { get; set; }

        [XmlAttribute(AttributeName = "extentID")]
        public int ExtentID { get; set; }
    }
}
