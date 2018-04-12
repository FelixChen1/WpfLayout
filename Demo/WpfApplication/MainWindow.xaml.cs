using System.Windows;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowDialog<DockPanelDialogView>();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShowDialog<WrapPanelDialogView>();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ShowDialog<GridPanelDialogView>();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ShowDialog<MixDialogView>();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ShowDialog<UserControlDialogView>();
        }

        private static void ShowDialog<T>() where T : Window, new()
        {
            T dialog = new T();
            dialog.ShowDialog();
        }

    }
}
