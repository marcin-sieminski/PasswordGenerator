using PasswordGenerator.Common;

namespace PasswordGenerator.ViewModel
{
    public class PasswordViewModel : ViewModelBase
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

    }
}
