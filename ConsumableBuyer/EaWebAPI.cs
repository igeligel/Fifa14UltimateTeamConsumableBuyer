using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Threading;

namespace ConsumableBuy
{
    public class EaWebApi
    {
        public string PricecheckFitness()
        {
            return "";
        }

        public string PricecheckContracts(string resourceId)
        {
            const string url =
                "https://utas.s2.fut.ea.com/ut/game/fifa14/transfermarket?num=16&cat=contract&start=0&type=development";
            var response = SearchRequest(url);
            var responseEntity = new JavaScriptSerializer().Deserialize<SearchResponseRootObject>(response);

            var auctions = responseEntity.auctionInfo
                .Where(item =>
                    item.itemData.resourceId.ToString() == resourceId &&
                    item.buyNowPrice != 0).Select(e => e.buyNowPrice).ToList();
            Thread.Sleep(700);

            var currentAuctions = 1;
            while (auctions.Count < 50 && currentAuctions < 100)
            {
                responseEntity = new JavaScriptSerializer()
                    .Deserialize<SearchResponseRootObject>(response);
                auctions.AddRange(from item in responseEntity.auctionInfo
                    where item.itemData.resourceId.ToString() == resourceId &&
                          item.buyNowPrice != 0
                    select item.buyNowPrice);
                currentAuctions = currentAuctions + 1;
                Thread.Sleep(700);
            }
            return new EaMath().AveragePrice(auctions).ToString();
        }

        public string SearchRequest(string url)
        {
            const string post = "";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.MediaType = "HTTP/1.1";

            request.CookieContainer = AccountData.CookieContainer;

            request.Method = "POST";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0";
            request.ContentType = "application/json; charset=UTF-8;";
            request.Headers.Add("X-HTTP-Method-Override", "GET");
            request.Headers.Add("X-UT-PHISHING-TOKEN", AccountData.WebPhishingToken);
            request.Headers.Add("X-UT-SID", AccountData.XultimateTeamId);

            var encoding = new ASCIIEncoding();
            var loginDataBytes = encoding.GetBytes(post);
            request.ContentLength = loginDataBytes.Length;
            var stream = request.GetRequestStream();
            stream.Write(loginDataBytes, 0, loginDataBytes.Length);
            stream.Close();
            var response = (HttpWebResponse)request.GetResponse();

            var dataStream = response.GetResponseStream();
            var str = new StreamReader(
                dataStream ?? throw new InvalidOperationException(),
                Encoding.UTF8);
            var responseContent = str.ReadToEnd();
            stream.Close();
            return responseContent;
        }

        public void ThrowException()
        {
            // ReSharper disable once NotResolvedInText
            throw new ArgumentException(@"Parameter cannot be null", "original");
        }
    }
}
