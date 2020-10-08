using System;
using System.Threading.Tasks;
using git_restman_automator.Connectors;

namespace git_restman_automator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ProcessReqest();
        }

        private static async Task ProcessReqest()
        {
            string retorno = await new RestmanConnector("apidev.intranet.mercantil.com.br:8443").GetBundleById("7a14d4c9896a5227b2839aee210f6574");
            Console.Write(retorno);
        }
    }
}
