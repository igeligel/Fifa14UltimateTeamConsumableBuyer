using System.Collections.Generic;

namespace ConsumableBuy
{
    internal class LoginData
    {
        private static LoginData _instance;
        private LoginData() { }
        internal static string Email;
        internal static string Password;
        internal static string SecurityHash;
        internal static string Platform;
        internal static List<string> UrLs = new List<string>();
        internal static LoginData Instance => _instance ?? (_instance = new LoginData());
    }
}
