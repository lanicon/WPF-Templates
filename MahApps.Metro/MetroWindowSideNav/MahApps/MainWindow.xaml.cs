using System.Windows;
using MahApps.Metro.Controls;
using MahApps.UI;

namespace MahApps
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ((MainViewModel)this.DataContext).CreateMenuItems();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            HamburgerMenuControl.SelectedIndex = -1;
            HamburgerMenuControl.SelectedOptionsIndex = -1;
        }
    }
}
