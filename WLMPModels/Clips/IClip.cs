using System;
using System.Collections.Generic;
using System.Text;

namespace WLMPModels.Clips
{
    public abstract class IClip
    {
        public abstract double TotalGapBefore();
        public abstract double TotalDuration();

        public double GetWidth()
        {
            return TotalDuration() * 50;
        }
    }
}
