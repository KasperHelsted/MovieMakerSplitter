using MovieMakerSplitter.BaseViewModel;
using MovieMakerSplitter.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;
using WLMPModels;

namespace MovieMakerSplitter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var viewModel = new MainViewModel();
            DataContext = viewModel;

            InitializeComponent();
            //Test();
        }

        public void Test()
        {
            Project pm = null;
            try
            {
                StreamReader str = new StreamReader(@"./Projects/test.wlmp");
                XmlSerializer xSerializer = new XmlSerializer(typeof(Project));
                pm = (Project)xSerializer.Deserialize(str);
                str.Close();

                XmlSerializer xs = new XmlSerializer(typeof(Project));
                TextWriter tw = new StreamWriter(@"./Projects/test_out.wlmp");
                xs.Serialize(tw, pm);

                Application.Current.Shutdown();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
