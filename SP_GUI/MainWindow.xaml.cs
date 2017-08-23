using System;
using System.Collections.Generic;
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
using StoryParser;

namespace SP_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Story _story;

        public MainWindow()
        {
            InitializeComponent();
            _story = new Story();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Timeline t = _story.Timelines[0];
            _story.Narrator = new Subject();
            _story.Narrator.Name = "Sadov";
            _story.Reader = new Subject();
            _story.Reader.Name = "Я";
            Subject character = new Subject();
            character.Name = "Yegor";
            _story.Subjects.Add(character);
            StoryPoint sp = new StoryPoint(t, TimeSpan.FromMinutes(1), "odin");
            t.Events.Add(sp);
            character.Lifeline.Add(new Lifepoint(sp, TimeSpan.FromMinutes(1)));
        }
    }
}
