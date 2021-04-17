using PasswordGenerator.Common;

namespace PasswordGenerator.ViewModel
{
    public class PasswordViewModel : ViewModelBase
    {
        private readonly PasswordModel _model = new()
        {
            PasswordLength = 25,
            CanContainUppercase = true,
            CanContainLowercase = true,
            CanContainNumbers = true,
            CanContainSpecialCharacters = true
        };

        public string Password
        {
            get => _model.Password;
            set
            {
                _model.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public int PasswordLength
        {
            get => _model.PasswordLength;
            set
            {
                _model.PasswordLength = value;
                OnPropertyChanged(nameof(PasswordLength));
            }
        }

        public bool CanContainUppercase
        {
            get => _model.CanContainUppercase;
            set
            {
                _model.CanContainUppercase = value;
                OnPropertyChanged(nameof(CanContainUppercase));
            }
        }

        public bool CanContainLowercase
        {
            get => _model.CanContainLowercase;
            set
            {
                _model.CanContainLowercase = value;
                OnPropertyChanged(nameof(CanContainLowercase));
            }
        }

        public bool CanContainNumbers
        {
            get => _model.CanContainNumbers;
            set
            {
                _model.CanContainNumbers = value;
                OnPropertyChanged(nameof(CanContainNumbers));
            }
        }

        public bool CanContainSpecialCharacters
        {
            get => _model.CanContainSpecialCharacters;
            set
            {
                _model.CanContainSpecialCharacters = value;
                OnPropertyChanged(nameof(CanContainSpecialCharacters));
            }
        }

        public void Generate()
        {
            _model.GeneratePassword();
            OnPropertyChanged(nameof(Password));
        }

        public void Clear()
        {
            _model.Password = string.Empty;
            OnPropertyChanged(nameof(Password));
        }
    }
}
