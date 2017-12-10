using System.Collections.Generic;

namespace ConsumableBuy
{
    public class StatsList
    {
        public int value { get; set; }
        public int index { get; set; }
    }

    public class LifetimeStat
    {
        public int value { get; set; }
        public int index { get; set; }
    }

    public class ItemData
    {
        public object id { get; set; }
        public int timestamp { get; set; }
        public string itemType { get; set; }
        public int teamid { get; set; }
        public int rating { get; set; }
        public int lastSalePrice { get; set; }
        public int owners { get; set; }
        public int morale { get; set; }
        public string formation { get; set; }
        public bool untradeable { get; set; }
        public int assetId { get; set; }
        public int resourceId { get; set; }
        public string itemState { get; set; }
        public string preferredPosition { get; set; }
        public List<object> attributeList { get; set; }
        public List<StatsList> statsList { get; set; }
        public List<LifetimeStat> lifetimeStats { get; set; }
        public int injuryGames { get; set; }
        public int training { get; set; }
        public int discardValue { get; set; }
        public int cardsubtypeid { get; set; }
        public string injuryType { get; set; }
        public int suspension { get; set; }
        public int fitness { get; set; }
        public int assists { get; set; }
        public int contract { get; set; }
        public int rareflag { get; set; }
        public int lifetimeAssists { get; set; }
    }

    public class AuctionInfo
    {
        public object tradeId { get; set; }
        public int buyNowPrice { get; set; }
        public int currentBid { get; set; }
        public ItemData itemData { get; set; }
        public string tradeState { get; set; }
        public int startingBid { get; set; }
        public int offers { get; set; }
        public string bidState { get; set; }
        public object watched { get; set; }
        public int expires { get; set; }
        public string sellerName { get; set; }
        public int sellerEstablished { get; set; }
        public int sellerId { get; set; }
    }

    public class BidTokens
    {
        public int count { get; set; }
        public int updateTime { get; set; }
    }

    public class Currency
    {
        public string name { get; set; }
        public int funds { get; set; }
        public int finalFunds { get; set; }
    }

    public class SearchResponseRootObject
    {
        public List<AuctionInfo> auctionInfo { get; set; }
        public int credits { get; set; }
        public BidTokens bidTokens { get; set; }
        public object duplicateItemIdList { get; set; }
        public List<Currency> currencies { get; set; }
        public object errorState { get; set; }
    }
}
