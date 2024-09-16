using System.Windows;
using NumberDrawing.ViewModel;
namespace NumberDrawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ValueModel valueModel = new ValueModel();
        private MainViewModel mainViewModel;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

    }
}