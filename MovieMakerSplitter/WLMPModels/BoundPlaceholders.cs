﻿using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "BoundPlaceholders")]
    public class BoundPlaceholders
    {
        [XmlElement(ElementName = "BoundPlaceholder")]
        public List<BoundPlaceholder> BoundPlaceholder { get; set; }
    }
}