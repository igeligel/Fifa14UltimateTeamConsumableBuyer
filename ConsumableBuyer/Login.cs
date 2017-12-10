using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace ConsumableBuy
{
    internal class Login
    {
        private readonly CookieContainer _cookieContainer = new CookieContainer();

        internal void StartLogin()
        {
            const string initialLogin = "http://www.easports.com/uk/fifa/football-club/ultimate-team";
            const string iframeUrl = "http://www.easports.com/iframe/fut/?locale=en_GB&baseShowoffUrl=http%3A%2F%2Fwww.easports.com%2Fpl%2Ffifa%2Ffootball-club%2Fultimate-team%2Fshow-off&guest_app_uri=http%3A%2F%2Fwww.easports.com%2Fpl%2Ffifa%2Ffootball-club%2Fultimate-team";
            var firstlocation = InitialRedirect(initialLogin); //RedirectRequest
            var secondlocation = Login_2(firstlocation, initialLogin); //RedirectRequest
            var loginlocation = Login_3(secondlocation, firstlocation); //RedirectRequest
            var authedLocation = Login_4(loginlocation); //LoginRequest
            var nextlocation = Login_5(authedLocation, loginlocation); //RedirectRequest
            var secondNextLocation = Login_6(nextlocation, authedLocation); //RedirectRequest
            var aa = Login_7(iframeUrl, secondNextLocation); //RedirectRequest
            var next = Login_8(aa); //RedirectRequest
            var showOffUrl = Login_9(next, aa);
            AccountData.NucleusId = GetEaswId(showOffUrl, next);
            GetAccountInfo(showOffUrl);
            Auth(showOffUrl);
            GetWebPhishingToken(showOffUrl, LoginData.SecurityHash, AccountData.XultimateTeamId);
            AccountData.CookieContainer = _cookieContainer;
        }

        /// <summary>
        /// Will save cookies and redirect.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string InitialRedirect(string url)
        {
            var request2 = (HttpWebRequest)WebRequest.Create(url);
            request2.AllowAutoRedirect = false;
            request2.CookieContainer = _cookieContainer;
            string location;
            using (var response2 = (HttpWebResponse)request2.GetResponse())
            {
                location = response2.Headers["Location"];
                _cookieContainer.Add(response2.Cookies);
            }
            LoginData.UrLs.Add(location);
            return location;
        }

        /// <summary>
        /// Collect cookies and redirect.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Ref"></param>
        /// <returns></returns>
        private string Login_2(string url, string Ref)
        {
            var request2 = (HttpWebRequest)WebRequest.Create(url);
            request2.AllowAutoRedirect = false;
            request2.Referer = Ref;
            request2.CookieContainer = _cookieContainer;
            string location;
            using (var response2 = (HttpWebResponse)request2.GetResponse())
            {
                location = response2.Headers["Location"];
                _cookieContainer.Add(response2.Cookies);
            }
            LoginData.UrLs.Add(location);
            return location;
        }

        /// <summary>
        /// Collect cookies and redirect.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Ref"></param>
        /// <returns></returns>
        private string Login_3(string url, string Ref)
        {
            var request2 = (HttpWebRequest)WebRequest.Create(url);
            request2.AllowAutoRedirect = false;
            if (!string.IsNullOrEmpty(Ref))
                request2.Referer = Ref;
            request2.CookieContainer = _cookieContainer;
            string location;
            using (var response2 = (HttpWebResponse)request2.GetResponse())
            {
                location = response2.Headers["Location"];
                _cookieContainer.Add(response2.Cookies);
            }
            return location;
        }

        /// <summary>
        /// Login.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string Login_4(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.AllowAutoRedirect = false;
            request.Method = "POST";
            var content = "email=" + LoginData.Email + "&password=" + LoginData.Password + "&_eventId=submit&_rememberMe=on&facebookAuth=";
            var contentBytes = Encoding.UTF8.GetBytes(content);
            request.ContentLength = contentBytes.Length;
            request.CookieContainer = _cookieContainer;
            request.ContentType = "application/x-www-form-urlencoded";
            var contentStream = request.GetRequestStream();
            contentStream.Write(contentBytes, 0, contentBytes.Length);
            contentStream.Close();
            string redirectUrl;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                _cookieContainer.Add(response.Cookies);
                redirectUrl = response.Headers["Location"];
            }
            return redirectUrl;
        }

        /// <summary>
        /// Redirect.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Ref"></param>
        /// <returns></returns>
        private string Login_5(string url, string Ref)
        {
            var request2 = (HttpWebRequest)WebRequest.Create(url);
            request2.AllowAutoRedirect = false;
            if (!string.IsNullOrEmpty(Ref))
                request2.Referer = Ref;
            request2.CookieContainer = _cookieContainer;
            string location;
            using (var response2 = (HttpWebResponse)request2.GetResponse())
            {
                location = response2.Headers["Location"];
                _cookieContainer.Add(response2.Cookies);
            }
            return location;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Ref"></param>
        /// <returns></returns>
        private string Login_6(string url, string Ref)
        {
            var request2 = (HttpWebRequest)WebRequest.Create(url);
            request2.AllowAutoRedirect = false;
            if (!string.IsNullOrEmpty(Ref))
                request2.Referer = Ref;
            request2.CookieContainer = _cookieContainer;
            string location;
            using (var response2 = (HttpWebResponse)request2.GetResponse())
            {
                location = response2.Headers["Location"];
                _cookieContainer.Add(response2.Cookies);
            }
            return location;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Ref"></param>
        /// <returns></returns>
        private string Login_7(string url, string Ref)
        {
            var request2 = (HttpWebRequest)WebRequest.Create(url);
            request2.AllowAutoRedirect = false;
            if (!string.IsNullOrEmpty(Ref))
                request2.Referer = Ref;
            request2.CookieContainer = _cookieContainer;
            string location;
            using (var response2 = (HttpWebResponse)request2.GetResponse())
            {
                location = response2.Headers["Location"];
                _cookieContainer.Add(response2.Cookies);
            }
            return location;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Ref"></param>
        /// <returns></returns>
        private string Login_8(string url, string Ref = "")
        {
            var request2 = (HttpWebRequest)WebRequest.Create(url);
            request2.AllowAutoRedirect = false;
            if (!string.IsNullOrEmpty(Ref))
                request2.Referer = Ref;
            request2.CookieContainer = _cookieContainer;
            string location;
            using (var response2 = (HttpWebResponse)request2.GetResponse())
            {
                location = response2.Headers["Location"];
                _cookieContainer.Add(response2.Cookies);
            }
            return location;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Ref"></param>
        /// <returns></returns>
        private string Login_9(string url, string Ref)
        {
            var request2 = (HttpWebRequest)WebRequest.Create(url);
            request2.AllowAutoRedirect = false;
            if (!string.IsNullOrEmpty(Ref))
                request2.Referer = Ref;
            request2.CookieContainer = _cookieContainer;
            string location;
            using (var response2 = (HttpWebResponse)request2.GetResponse())
            {
                location = response2.Headers["Location"];
                _cookieContainer.Add(response2.Cookies);
            }
            return location;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Ref"></param>
        /// <returns></returns>
        private string GetEaswId(string url, string Ref)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.AllowAutoRedirect = false;
            request.Referer = Ref;
            request.CookieContainer = _cookieContainer;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(responseStream ?? throw new InvalidOperationException()))
                    {
                        var getString = reader.ReadToEnd();
                        var match = Regex.Match(getString, @".*var EASW_ID = \'(.*?)\'.*", RegexOptions.IgnoreCase);
                        var token = match.Value;
                        return Regex.Match(token, @"\d+").Value;
                    }
                }
            }
        }

        /// <summary>
        /// Getting account information like persona id, persona name.
        /// </summary>
        /// <param name="referer"></param>
        private void GetAccountInfo(string referer)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://www.easports.com/iframe/fut/p/ut/game/fifa14/user/accountinfo?_=");
            request.CookieContainer = _cookieContainer;
            request.Referer = referer;
            ExtendHttpHeader(ref request);

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(responseStream ?? throw new InvalidOperationException()))
                    {
                        var retStr = reader.ReadToEnd();
                        var returnedResponse = new JavaScriptSerializer().Deserialize<UserAccountInfoRootObject>(retStr);
                        foreach (var item in returnedResponse.userAccountInfo.personas)
                        {
                            AccountData.PersonaId = item.personaId.ToString();
                            AccountData.PersonaName = item.personaName;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Final authentication. X-Ultimate-Team Id will be saved.
        /// </summary>
        /// <param name="showOffUrl"></param>
        private void Auth(string showOffUrl)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://www.easports.com/iframe/fut/p/ut/auth");

            var content = "{ \"isReadOnly\": false, \"sku\": \"FUT14WEB\", \"clientVersion\": 1, \"nuc\": " + AccountData.NucleusId + ", \"nucleusPersonaId\": " + AccountData.PersonaId + ", \"nucleusPersonaDisplayName\": \"" + AccountData.PersonaName + "\", \"nucleusPersonaPlatform\": \"" + LoginData.Platform + "\", \"locale\": \"en-GB\", \"method\": \"authcode\", \"priorityLevel\":4, \"identification\": { \"authCode\": \"\" } }";
            var contentBytes = Encoding.UTF8.GetBytes(content);
            request.ContentLength = contentBytes.Length;
            request.AllowAutoRedirect = false;
            request.ContentType = "application/json; charset=UTF-8;";
            request.Method = "POST";
            request.Referer = showOffUrl;
            ExtendHttpHeader(ref request);
            request.CookieContainer = _cookieContainer;

            var contenStream = request.GetRequestStream();
            contenStream.Write(contentBytes, 0, contentBytes.Length);
            contenStream.Close();
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                _cookieContainer.Add(response.Cookies);
                using (var responseStream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(responseStream ?? throw new InvalidOperationException()))
                    {
                        var returnedResponse = new JavaScriptSerializer().Deserialize<Session>(reader.ReadToEnd());
                        foreach (var item in returnedResponse.Sid)
                        {
                            AccountData.XultimateTeamId += item.ToString();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Security answer and secure id.
        /// </summary>
        /// <param name="referer"></param>
        /// <param name="secAnswer"></param>
        /// <param name="xutSessionId"></param>
        private void GetWebPhishingToken(string referer, string secAnswer, string xutSessionId)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://www.easports.com/iframe/fut/p/ut/game/fifa14/phishing/validate");
            request.CookieContainer = _cookieContainer;
            request.Referer = referer;
            request.Method = "POST";


            ExtendHttpHeader(ref request);
            request.Headers.Add("X-UT-SID", xutSessionId);


            var content = "answer=" + secAnswer;
            var contentBytes = Encoding.Default.GetBytes(content);

            request.ContentLength = contentBytes.Length;

            var contenStream = request.GetRequestStream();

            contenStream.Write(contentBytes, 0, contentBytes.Length);
            contenStream.Close();

            request.AllowAutoRedirect = false;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    _cookieContainer.Add(response.Cookies);
                    using (var reader = new StreamReader(responseStream ?? throw new InvalidOperationException()))
                    {
                        var getString = reader.ReadToEnd();
                        var returnedResponse = new JavaScriptSerializer().Deserialize<PhishingKey>(getString);
                        foreach (var item in returnedResponse.token)
                        {
                            AccountData.WebPhishingToken += item.ToString();
                        }
                    }
                }
            }
        }

        private static void ExtendHttpHeader(ref HttpWebRequest request)
        {
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            request.Headers.Add("X-UT-Embed-Error", "true");
            request.Headers.Add("X-UT-Route", "https://utas.s2.fut.ea.com:443");
            request.Headers.Add("Easw-Session-Data-Nucleus-Id", AccountData.NucleusId);
        }

        public class Session
        {
            public string ServerTime { get; set; }
            public object LastOnlineTime { get; set; }
            public string Sid { get; set; }
            public string IpPort { get; set; }
        }

        public class PhishingKey
        {
            // ReSharper disable once InconsistentNaming
            public string debug { get; set; }
            // ReSharper disable once InconsistentNaming
            public string @string { get; set; }
            // ReSharper disable once InconsistentNaming
            public string reason { get; set; }
            // ReSharper disable once InconsistentNaming
            public string token { get; set; }
            // ReSharper disable once InconsistentNaming
            public string code { get; set; }
        }

    }
}
