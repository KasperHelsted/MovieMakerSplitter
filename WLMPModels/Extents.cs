using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using WLMPModels.Clips;

namespace WLMPModels
{
    [XmlRoot(ElementName = "Extents")]
    public class Extents
    {
        [XmlElement(ElementName = "ImageClip")]
        public List<ImageClip> ImageClip { get; set; }

        [XmlElement(ElementName = "AudioClip")]
        public List<AudioClip> AudioClip { get; set; }

        [XmlElement(ElementName = "VideoClip")]
        public List<VideoClip> VideoClip { get; set; }

        [XmlElement(ElementName = "TitleClip")]
        public List<TitleClip> TitleClip { get; set; }

        [XmlElement(ElementName = "ExtentSelector")]
        public List<ExtentSelector> ExtentSelector { get; set; }
    }
}
