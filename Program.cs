using System;
using git_restman_automator.Connectors;

namespace git_restman_automator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(new RestmanConnector("apidev.intranet.mercantil.com.br").GetBundleById("7a14d4c9896a5227b2839aee210f6574"));
        }
    }
}
