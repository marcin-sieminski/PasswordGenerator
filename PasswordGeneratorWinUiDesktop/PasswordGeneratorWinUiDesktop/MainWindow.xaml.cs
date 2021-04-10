using Microsoft.UI.Xaml;
using PasswordGenerator.Common;
using PasswordGenerator.ViewModel;


namespace PasswordGeneratorWinUiDesktop
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new PasswordViewModel(new PasswordModel());
        }

        public PasswordViewModel ViewModel { get; }
    }
}
