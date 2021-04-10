using System;
using System.Text;

namespace PasswordGenerator.Common
{
    public class PasswordGeneratorModel
    {
        public string Password { get; private set; }
        public bool CanContainUppercase { get; set; }
        public bool CanContainLowercase { get; set; }
        public bool CanContainNumbers { get; set; }
        public int PasswordLength { get; set; }

        public void GeneratePassword()
        {
            var newPasswordChars = new char[PasswordLength];

            const int minAsciiCode = 48;
            const int maxAsciiCode = 122;

            var random = new Random();
            var charCounter = 0;

            do
            {
                var randomValue = random.Next(minAsciiCode, maxAsciiCode + 1);
                if (randomValue >= 48 && randomValue <= 57 || randomValue >= 65 && randomValue <= 90 || randomValue >= 97 && randomValue <= 122)
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
