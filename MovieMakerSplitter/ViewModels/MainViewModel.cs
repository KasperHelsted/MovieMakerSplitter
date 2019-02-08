using Microsoft.Win32;
using MovieMakerSplitter.BaseViewModel;
using MovieMakerSplitter.ViewModels.Helpers;
using MovieMakerSplitter.WLMPModels;
using MovieMakerSplitter.WLMPModels.Clips;
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

namespace MovieMakerSplitter.ViewModels
{
    class MainViewModel : BaseViewModel.BaseViewModel
    {
        public BoundPlaceholder Texts { get; set; } = null;
        public BoundPlaceholder Audios { get; set; } = null;

        #region Medias
        public List<ExtentRef> _medias = new List<ExtentRef>();
        public List<ExtentRef> Medias
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

        public ICommand IOpenFile
        {
            get
            {
                return new RelayCommand(x =>
                {
                    OpenFileDialog dlg = new OpenFileDialog();

                    dlg.DefaultExt = ".wlmp";
                    dlg.Filter = "Windows Movie Maker Projects (*.wlmp)|*.wlmp";

                    Nullable<bool> result = dlg.ShowDialog();

                    if (result == true)
                    {

                        OpenFile(dlg.FileName);
                    }
                });
            }
        }

        private void OpenFile(string path)
        {
            try
            {
                StreamReader str = new StreamReader(path);
                XmlSerializer xSerializer = new XmlSerializer(typeof(Project));
                StaticData.project = (Project)xSerializer.Deserialize(str);
                str.Close();

                Title = StaticData.project.Name;

                foreach (var BoundPlaceholder in StaticData.project.BoundPlaceholders.BoundPlaceholder)
                {
                    switch (BoundPlaceholder.PlaceholderID)
                    {
                        case "Main":
                            Medias = GetExtentRefs(GetExtentSelector(BoundPlaceholder.ExtentID));
                            break;
                        case "SoundTrack":
                            break;
                    }
                }

            }
            catch (XmlException)
            {
                MessageBox.Show("Unable to open project", "Oopsie");
            }
        }


        private List<ExtentRef> GetExtentRefs(ExtentSelector extentSelector)
        {
            return extentSelector.ExtentRefs.ExtentRef;
        }

        private ExtentSelector GetExtentSelector(int ExtentID)
        {
            foreach (ExtentSelector extentSelector in StaticData.project.Extents.ExtentSelector)
                if (extentSelector.ExtentID == ExtentID)
                    return extentSelector;
            return null;
        }
    }
}
