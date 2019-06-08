using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;

namespace BusinessLogic
{
    public class TransactionsService
    {
        public List<Transactions> GetTransactions(TransactionsFilter filter)
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Variables.UserNameAuth}:{Variables.PasswordAuth}")));

                    var builder = new UriBuilder(Variables.EndpointAuth);
                    var query = HttpUtility.ParseQueryString(builder.Query);
                    if (filter.Action != null)
                    {
                        query["action"] = filter.Action;
                    }
                    if (filter.CurrencyCode != null)
                    {
                        query["currencyCode"] = filter.CurrencyCode;
                    }
                    builder.Query = query.ToString();
                    string url = builder.ToString();

                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content;
                        string responseString = responseContent.ReadAsStringAsync().Result;

                        List<Transactions> transactionsList = JsonConvert.DeserializeObject<List<Transactions>>(responseString);
                        return transactionsList;
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
