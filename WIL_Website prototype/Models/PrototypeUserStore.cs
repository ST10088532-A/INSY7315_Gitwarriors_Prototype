namespace WIL_Website_prototype.Models
{
    /// <summary>
    /// Temporary in-memory storage for prototype only. Replace with a database later.
    /// </summary>
    public static class PrototypeUserStore
    {
        private static readonly List<Register> Users = new();

        public static bool TryRegister(Register user, out string? errorMessage)
        {
            errorMessage = null;

            if (Users.Any(u => u.Email.Equals(user.Email, StringComparison.OrdinalIgnoreCase)))
            {
                errorMessage = "An account with this email already exists.";
                return false;
            }

            Users.Add(new Register
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Password = user.Password,
                Confirmpassword = user.Confirmpassword
            });

            return true;
        }

        public static bool TryLogin(string email, string password, out Register? user)
        {
            user = Users.FirstOrDefault(u =>
                u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);

            return user != null;
        }

        public static bool EmailExists(string email)
        {
            return Users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
}
