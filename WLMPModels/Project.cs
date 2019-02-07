using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace WLMPModels
{
    [XmlRoot(ElementName = "Project")]
    public class Project
    {
        [XmlElement(ElementName = "MediaItems")]
        public MediaItems MediaItems { get; set; }

        [XmlElement(ElementName = "Extents")]
        public Extents Extents { get; set; }

        [XmlElement(ElementName = "BoundPlaceholders")]
        public BoundPlaceholders BoundPlaceholders { get; set; }

        [XmlElement(ElementName = "BoundProperties")]
        public BoundProperties BoundProperties { get; set; }

        [XmlElement(ElementName = "ThemeOperationLog")]
        public ThemeOperationLog ThemeOperationLog { get; set; }

        [XmlElement(ElementName = "AudioDuckingProperties")]
        public AudioDuckingProperties AudioDuckingProperties { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "themeId")]
        public string ThemeId { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlAttribute(AttributeName = "templateID")]
        public string TemplateID { get; set; }
    }

}
