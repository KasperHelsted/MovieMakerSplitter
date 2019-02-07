using Microsoft.Win32;
using MovieMakerSplitter.BaseViewModel;
using MovieMakerSplitter.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml;
using System.Xml.Serialization;
using WLMPModels;
using WLMPModels.Clips;

namespace MovieMakerSplitter.ViewModels
{
    class MainViewModel : BaseViewModel.BaseViewModel
    {
        private Project project = null;

        public BoundPlaceholder Texts { get; set; } = null;
        public BoundPlaceholder Audios { get; set; } = null;

        #region Medias
        public List<ExtentRefWrapper> _medias = new List<ExtentRefWrapper>();
        public List<ExtentRefWrapper> Medias
        {
            get
            {
                return _medias;
            }
            set
            {
                _medias = value;
                OnPropertyChanged("Medias");
            }
        }
        #endregion

        #region Title
        private string _title = "Choose project to load";
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }
        #endregion

        public ICommand GoTo2
        {
            get
            {
                return new RelayCommand(x =>
                {
                    OpenFile();
                });
            }
        }

        private void OpenFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.DefaultExt = ".wlmp";
            dlg.Filter = "Windows Movie Maker Projects (*.wlmp)|*.wlmp";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                try
                {
                    StreamReader str = new StreamReader(dlg.FileName);
                    XmlSerializer xSerializer = new XmlSerializer(typeof(Project));
                    project = (Project)xSerializer.Deserialize(str);
                    str.Close();

                    Title = project.Name;

                    foreach (var BoundPlaceholder in project.BoundPlaceholders.BoundPlaceholder)
                    {
                        if (BoundPlaceholder.PlaceholderID == "Main")
                        {
                            Medias = GetExtentRefWrappers(GetExtentSelector(BoundPlaceholder.ExtentID));
                        }
                        else if (BoundPlaceholder.PlaceholderID == "SoundTrack")
                        {

                        }
                    }

                }
                catch (XmlException)
                {
                    MessageBox.Show("Unable to open project", "Oopsie");
                }
            }
        }

        private List<ExtentRefWrapper> GetExtentRefWrappers(ExtentSelector extentSelector)
        {
            List<ExtentRef> extentRef = extentSelector.ExtentRefs.ExtentRef;

            return extentRef.Select(x => GetExtentRefWrapper(x)).ToList();

        }

        private ExtentRefWrapper GetExtentRefWrapper(ExtentRef extentRef)
        {
            return new ExtentRefWrapper(extentRef, GetMedia(extentRef));
        }

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

        private ExtentSelector GetExtentSelector(int ExtentID)
        {
            foreach (ExtentSelector s in project.Extents.ExtentSelector)
                if (s.ExtentID == ExtentID)
                    return s;
            return null;
        }
    }
}
