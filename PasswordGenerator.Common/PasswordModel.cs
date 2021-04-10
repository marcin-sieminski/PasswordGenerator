using System;
using System.Text;

namespace PasswordGenerator.Common
{
    public class PasswordModel
    {
        public string Password { get; private set; }
        public bool CanContainUppercase { get; set; } = true;
        public bool CanContainLowercase { get; set; } = true;
        public bool CanContainNumbers { get; set; } = true;
        public bool CanContainSpecialCharacters { get; set; } = true;
        public int PasswordLength { get; set; } = 10;

        public void GeneratePassword()
        {
            var newPasswordChars = new char[PasswordLength];

            const int minAsciiCode = 33;
            const int maxAsciiCode = 122;

            var random = new Random();
            var charCounter = 0;

            do
            {
                var randomValue = random.Next(minAsciiCode, maxAsciiCode + 1);

                if (CanContainNumbers && randomValue >= 48 && randomValue <= 57 || 
                    CanContainUppercase && randomValue >= 65 && randomValue <= 90 || 
                    CanContainLowercase && randomValue >= 97 && randomValue <= 122 ||
                    CanContainSpecialCharacters && randomValue >= 33 && randomValue <= 47)
                {
                    newPasswordChars[charCounter] = (char)randomValue;
                    charCounter++;
                }
            } while (charCounter < PasswordLength);

            var passwordStringBuilder = new StringBuilder();
            for (var i = 0; i < PasswordLength; i++)
            {
                passwordStringBuilder.Append(newPasswordChars[i]);
            }

            Password = passwordStringBuilder.ToString();
        }
    }
}
