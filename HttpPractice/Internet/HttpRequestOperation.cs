using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HttpPractice.Internet.Interfaces;
using HttpPractice.Helper;
using HttpPractice.Models;
using Newtonsoft.Json;

namespace HttpPractice.Internet
{
    public class HttpRequestOperation : IHttpRequest
    {
        public async Task<List<CompanyData>> MakeHttpRequestFromInternet()
        {
            List<CompanyData> response = new List<CompanyData>();

            using (HttpClient client = new HttpClient())
            {
                var responseFromInternetApiCall = await client.GetAsync(Constants.URL);

                var resultInJson = await responseFromInternetApiCall.Content.ReadAsStringAsync();

                var deserialisedJson = JsonConvert.DeserializeObject<CompanyDetail>(resultInJson);

                response = deserialisedJson.data;
            }

            return response;
        }
    }
}
