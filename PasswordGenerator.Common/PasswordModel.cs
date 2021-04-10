namespace PasswordGenerator.Common
{
    public class PasswordModel
    {
        public string Password { get; set; }
        public bool CanContainUppercase { get; set; }
        public bool CanContainLowercase { get; set; }
        public bool CanContainNumbers { get; set; }
    }
}
