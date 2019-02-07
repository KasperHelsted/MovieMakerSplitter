using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace WLMPModels
{
    [XmlRoot(ElementName = "MediaItems")]
    public class MediaItems
    {
        [XmlElement(ElementName = "MediaItem")]
        public List<MediaItem> MediaItem { get; set; }
    }
}
