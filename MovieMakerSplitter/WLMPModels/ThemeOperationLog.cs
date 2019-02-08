using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "ThemeOperationLog")]
    public class ThemeOperationLog
    {
        [XmlElement(ElementName = "MonolithicThemeOperations")]
        public string MonolithicThemeOperations { get; set; }
        [XmlAttribute(AttributeName = "themeID")]
        public string ThemeID { get; set; }
    }
}
