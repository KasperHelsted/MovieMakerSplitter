using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "ExtentRef")]
    public class ExtentRef
    {
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }


        /*
        private IClip GetMedia(ExtentRef extentRef)
        {
            foreach (AudioClip audioClip in project.Extents.AudioClip)
                if (audioClip.ExtentID == extentRef.Id)
                    return audioClip;
            foreach (VideoClip videoClip in project.Extents.VideoClip)
                if (videoClip.ExtentID == extentRef.Id)
                    return videoClip;
            foreach (ImageClip imageClip in project.Extents.ImageClip)
                if (imageClip.ExtentID == extentRef.Id)
                    return imageClip;
            foreach (TitleClip titleClip in project.Extents.TitleClip)
                if (titleClip.ExtentID == extentRef.Id)
                    return titleClip;

            MessageBox.Show("test");
            return null;
        }
        */

    }
}
