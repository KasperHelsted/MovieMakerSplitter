using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace MovieMakerSplitter.WLMPModels
{
    [XmlRoot(ElementName = "MediaItem")]
    public class MediaItem
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "filePath")]
        public string FilePath { get; set; }
        [XmlAttribute(AttributeName = "arWidth")]
        public string ArWidth { get; set; }
        [XmlAttribute(AttributeName = "arHeight")]
        public string ArHeight { get; set; }
        [XmlAttribute(AttributeName = "duration")]
        public double Duration { get; set; }
        [XmlAttribute(AttributeName = "songTitle")]
        public string SongTitle { get; set; }
        [XmlAttribute(AttributeName = "songArtist")]
        public string SongArtist { get; set; }
        [XmlAttribute(AttributeName = "songAlbum")]
        public string SongAlbum { get; set; }
        [XmlAttribute(AttributeName = "songCopyrightUrl")]
        public string SongCopyrightUrl { get; set; }
        [XmlAttribute(AttributeName = "songArtistUrl")]
        public string SongArtistUrl { get; set; }
        [XmlAttribute(AttributeName = "songAudioFileUrl")]
        public string SongAudioFileUrl { get; set; }
        [XmlAttribute(AttributeName = "stabilizationMode")]
        public string StabilizationMode { get; set; }
        [XmlAttribute(AttributeName = "mediaItemType")]
        public string MediaItemType { get; set; }
    }
}
