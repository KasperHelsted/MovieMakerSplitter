using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels.Clips
{
    [XmlRoot(ElementName = "VideoClip")]
    public class VideoClip : IClip
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

        [XmlAttribute(AttributeName = "inTime")]
        public double InTime { get; set; }

        [XmlAttribute(AttributeName = "outTime")]
        public double OutTime { get; set; }

        [XmlAttribute(AttributeName = "speed")]
        public string Speed { get; set; }

        [XmlAttribute(AttributeName = "stabilizationMode")]
        public string StabilizationMode { get; set; }

        public override ClipType getClipType()
        {
            return ClipType.Video;
        }

        public override double TotalDuration()
        {
            return (OutTime - InTime);
        }

        public override double TotalGapBefore()
        {
            return 0;
        }
    }
}
