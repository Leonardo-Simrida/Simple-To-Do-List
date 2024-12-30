using Simple_To_Do_List.MVVM.ViewModels;
using System.Windows;

namespace Simple_To_Do_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            DataContext = mainWindowViewModel;
        }
    }
}