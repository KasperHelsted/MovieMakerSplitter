using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WLMPModels;
using WLMPModels.Clips;

namespace MovieMakerSplitter.ViewModels.Helpers
{
    class ExtentRefWrapper
    {
        public ExtentRef extentRef = null;
        public IClip iclip = null;

        public string Name { get; set; }

        public ExtentRefWrapper(ExtentRef _extentRef, IClip _clip)
        {
            extentRef = _extentRef;
            iclip = _clip;

            if (iclip.GetWidth() < 0)
            {
                var t = 1;
            }

            Name = iclip.ToString();
        }
    }
}
