using Microsoft.UI.Xaml;
using PasswordGenerator.ViewModel;


namespace PasswordGeneratorWinUiDesktop
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new PasswordViewModel();
        }

        public PasswordViewModel ViewModel { get; }
    }
}
