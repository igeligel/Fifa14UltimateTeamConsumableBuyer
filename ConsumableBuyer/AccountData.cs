using System.Net;

namespace ConsumableBuy
{
    internal class AccountData
    {
        private static AccountData _instance;
        public static string NucleusId;
        public static string PersonaId;
        public static string PersonaName;
        public static string XultimateTeamId;
        public static string WebPhishingToken;
        public static CookieContainer CookieContainer = new CookieContainer();
        private AccountData() { }
        public static AccountData Instance => _instance ?? (_instance = new AccountData());
    }
}
