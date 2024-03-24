using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using taskManagerWPF.ViewModels;

namespace taskManagerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TaskManagerViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new TaskManagerViewModel();
            DataContext = _viewModel;
        }
    }
}