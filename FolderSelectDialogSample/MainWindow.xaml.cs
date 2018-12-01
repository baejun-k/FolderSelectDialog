using System.Windows;

namespace FolderSelectDialogSample {
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e) {
            FolderSelectDialog fsd = new FolderSelectDialog();
            fsd.Multiselect = true;
            if (fsd.ShowDialog()) {
                string[] dirs = fsd.FileNames;
                lstview.ItemsSource = dirs;
            }
        }
    }
}
