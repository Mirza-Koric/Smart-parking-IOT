using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EmguCvProject
{
    internal class Conectivity
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task Post()
        {
            var values = new Dictionary<string, string>
             {
                { "number", $"{Form1.broj}" }
             };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://www.example.com/recepticle.aspx", content);

            var responseString = await response.Content.ReadAsStringAsync();

        }

        public async Task GetStuff()
        {
            string response = await client.GetStringAsync("https.//jsonplaceholder.typecode.com/todos");
        }
    }
}
