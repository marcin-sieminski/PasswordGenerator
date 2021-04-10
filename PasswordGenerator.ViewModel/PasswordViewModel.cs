using PasswordGenerator.Common;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PasswordGenerator.ViewModel
{
    public class PasswordViewModel : INotifyPropertyChanged
    {
        private readonly PasswordModel _password;

        public PasswordViewModel(PasswordModel password)
        {
            _password = password;
        }

        public string Password
        {
            get => _password.Password;
            set
            {
                if (_password.Password != value)
                {
                    _password.Password = value;
                    RaisePropertyChanged(nameof(Password));
                }
            }
        }

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
