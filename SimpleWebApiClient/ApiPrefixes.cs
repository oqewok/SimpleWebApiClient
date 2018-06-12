using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApiClient
{
    public class ApiPrefixes
    {
        public string LocalHttpPrefix { get; set; } = "http://195.239.209.250:8010";
        public string LocalHttpsPrefix { get; set; } = "https://195.239.209.250:8010";

        public string RemoteHttpPrefix { get; set; } = "http://195.239.209.250:8010";
        public string RemoteHttpsPrefix { get; set; } = "https://195.239.209.250:8010";

        public ApiPrefixes()
        {

        }

        public List<string> ToList()
        {
            return new List<string>
            {
                LocalHttpPrefix,
                RemoteHttpPrefix,
                LocalHttpsPrefix,
                RemoteHttpsPrefix
            };
        }
    }
}
