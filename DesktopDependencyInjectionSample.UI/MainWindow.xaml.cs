using System.Windows;

namespace DesktopDependencyInjectionSample.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IGreeter _greeter;

        public MainWindow(IGreeter greeter)
        {
            _greeter = greeter;
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_greeter.Greet("Rafael"));
        }
    }
}
