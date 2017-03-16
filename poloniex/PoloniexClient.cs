using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poloniex
{
    class PoloniexClient
    {
        private string apiKey;
        private string secret;

        public PoloniexClient(string apiKey, string secret)
        {
            this.apiKey = apiKey;
            this.secret = secret;
        }
    }
}
