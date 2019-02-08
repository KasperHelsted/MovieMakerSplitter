using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels.Clips
{
    [XmlRoot(ElementName = "TitleClip")]
    public class TitleClip : IClip
    {
        [XmlElement(ElementName = "Transitions")]
        public string Transitions { get; set; }

        [XmlElement(ElementName = "BoundProperties")]
        public BoundProperties BoundProperties { get; set; }

        [XmlAttribute(AttributeName = "extentID")]
        public int ExtentID { get; set; }

        [XmlAttribute(AttributeName = "gapBefore")]
        public double GapBefore { get; set; }

        [XmlAttribute(AttributeName = "duration")]
        public double Duration { get; set; }

        [XmlElement(ElementName = "Effects")]
        public Effects Effects { get; set; }

        public override ClipType getClipType()
        {
            return ClipType.Title;
        }

        public override double TotalDuration()
        {
            return Duration;
        }

        public override double TotalGapBefore()
        {
            return GapBefore;
        }
    }
}
