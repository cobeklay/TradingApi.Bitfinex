﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;

namespace TradingApi.ModelObjects.Bitfinex.Json
{
    public class BitfinexBalanceResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("available")]
        public decimal Available { get; set; }

       public override string ToString()
       {
          var str = string.Format("Type: {0}, Currency: {1}, Amount: {2}, Available: {3}", Type, Currency, Amount,Available);
          return str;
       }
    }

}
