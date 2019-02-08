using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "TextEffect")]
    public class TextEffect
    {
        [XmlElement(ElementName = "BoundProperties")]
        public BoundProperties BoundProperties { get; set; }
        [XmlAttribute(AttributeName = "effectTemplateID")]
        public string EffectTemplateID { get; set; }
        [XmlAttribute(AttributeName = "TextScriptId")]
        public string TextScriptId { get; set; }
    }
}
