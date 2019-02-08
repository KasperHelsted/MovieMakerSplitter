using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels.Clips
{
    [XmlRoot(ElementName = "ImageClip")]
    public class ImageClip : IClip
    {
        [XmlElement(ElementName = "Effects")]
        public string Effects { get; set; }

        [XmlElement(ElementName = "Transitions")]
        public string Transitions { get; set; }

        [XmlElement(ElementName = "BoundProperties")]
        public BoundProperties BoundProperties { get; set; }

        [XmlAttribute(AttributeName = "extentID")]
        public int ExtentID { get; set; }

        [XmlAttribute(AttributeName = "gapBefore")]
        public string GapBefore { get; set; }

        [XmlAttribute(AttributeName = "mediaItemID")]
        public string MediaItemID { get; set; }

        [XmlAttribute(AttributeName = "duration")]
        public double Duration { get; set; }

        public override ClipType getClipType()
        {
            return ClipType.Image;
        }

        public override double TotalDuration()
        {
            return Duration;
        }

        public override double TotalGapBefore()
        {
            return 0;
        }
    }
}
