using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels.Clips
{
    [XmlRoot(ElementName = "AudioClip")]
    public class AudioClip : IClip
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
        public double GapBefore { get; set; }

        [XmlAttribute(AttributeName = "mediaItemID")]
        public string MediaItemID { get; set; }

        [XmlAttribute(AttributeName = "inTime")]
        public double InTime { get; set; }

        [XmlAttribute(AttributeName = "outTime")]
        public double OutTime { get; set; }

        [XmlAttribute(AttributeName = "speed")]
        public string Speed { get; set; }

        public override ClipType getClipType()
        {
            return ClipType.Audio;
        }

        public override double TotalGapBefore()
        {
            return GapBefore;
        }

        public override double TotalDuration()
        {
            return (OutTime - InTime);
        }
    }
}
