using System.Windows;

namespace HowToCreateLookUpEdit {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            lookUpEdit1.ItemsSource = new ProductList();
        }
    }
}
