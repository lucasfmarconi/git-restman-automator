using System;
using System.Threading.Tasks;
using git_restman_automator.Connectors.Util;

namespace git_restman_automator.Connectors
{
    public class RestmanConnector
    {
        private readonly RestClient client = new RestClient();
        private readonly string _hostExport;

        public RestmanConnector(string hostExport)
        {
            _hostExport = hostExport;
        }

        public async Task<string> GetBundleById(string id)
        {
            string uriPath
                = $"https://{_hostExport}/restman/1.0/bundle?defaultAction=NewOrUpdate&includeDependencies=false&folder={id}&includeOnlyServicePolicy=true";
            var uri = new Uri(uriPath);

            var response = await client.ProcessGetRequest(uri);

            return response;
        }
    }
}