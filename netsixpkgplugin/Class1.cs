using Dynamo.Extensions;

namespace netsixpkgplugin
{
    public class IsolatedExtension: Dynamo.Extensions.IExtension
    {
        public string UniqueId => "cbf67bd6-4af6-46b6-99ed-73218c9407b8";

        public string Name => "IsolatedExtension";

        RestSharp.RestClient RestSharpRestClient { get; set; }
        public void BuildClient()
        {
            RestSharpRestClient = new RestSharp.RestClient();
        }

        public void Dispose()
        {
            RestSharpRestClient.Dispose();
        }

        public void Ready(ReadyParams sp)
        {
            BuildClient();
        }

        public void Shutdown()
        {
            RestSharpRestClient.Dispose();
        }

        public void Startup(StartupParams sp)
        {
            BuildClient();
        }
    }
}