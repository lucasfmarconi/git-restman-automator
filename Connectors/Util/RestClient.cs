using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace git_restman_automator.Connectors.Util
{
    public class RestClient
    {
        private readonly HttpClient client = new HttpClient();

        public RestClient()
        {
        }

        public async Task<string> ProcessGetRequest(Uri uri, MediaTypeWithQualityHeaderValue mediaType = null)
        {
            client.DefaultRequestHeaders.Accept.Clear();

            if (mediaType != null)
                client.DefaultRequestHeaders.Accept.Add(mediaType);

            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync(uri.AbsoluteUri);
            var msg = await stringTask;
            return msg;
        }
    }
}
