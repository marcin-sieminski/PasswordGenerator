using PasswordGenerator.Common;
using System.Windows.Input;

namespace PasswordGenerator.ViewModel
{
    public class PasswordViewModel : ViewModelBase
    {
        private readonly PasswordModel _password;
        public string Password => _password.Password;
        public bool CanContainUppercase 
        { 
            get => _password.CanContainUppercase;
            set => _password.CanContainUppercase = value;
        }
        //public bool CanContainLowercase { get; set; } = true;
        //public bool CanContainNumbers { get; set; } = true;
        //public bool CanContainSpecialCharacters { get; set; } = true;
        public int PasswordLength { get => _password.PasswordLength; set => _password.PasswordLength = value; }

        public PasswordViewModel(PasswordModel password)
        {
            _password = password;
        }


        public void Load()
        {
            _password.GeneratePassword();
        }

        private ICommand generatePasswordCommand;

        public ICommand GeneratePassword
        {
            get
            {
                if (generatePasswordCommand == null)
                {
                    //generatePasswordCommand = new RelayCommand((object agument) =>
                    //{

                    //});
                }
                return generatePasswordCommand;
            }
        }
    }

}
