﻿using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "AudioDuckingProperties")]
    public class AudioDuckingProperties
    {
        [XmlAttribute(AttributeName = "emphasisPlaceholderID")]
        public string EmphasisPlaceholderID { get; set; }
    }
}
