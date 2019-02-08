using MovieMakerSplitter.WLMPModels;
using MovieMakerSplitter.WLMPModels.Clips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieMakerSplitter.ViewModels.Helpers
{
    class ExtentRefWrapper
    {
        public ExtentRef extentRef = null;
        public IClip iclip = null;

        public ClipType ClipType { get; set; }
        public double Width { get; set; }

        public bool IsImage
        {
            get { return ClipType == ClipType.Image; }
        }
        public bool IsTitle
        {
            get { return ClipType == ClipType.Title; }
        }

        public bool IsElse
        {
            get { return ClipType != ClipType.Image && ClipType != ClipType.Title; }
        }
    }
}
