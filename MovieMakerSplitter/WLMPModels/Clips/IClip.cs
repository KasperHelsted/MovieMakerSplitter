using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMakerSplitter.WLMPModels.Clips
{
    public enum ClipType { Title, Image, Audio, Video };

    public abstract class IClip
    {
        public abstract double TotalGapBefore();
        public abstract double TotalDuration();

        public abstract ClipType getClipType();

        public double GetWidth()
        {
            return TotalDuration() * 50;
        }
    }
}
