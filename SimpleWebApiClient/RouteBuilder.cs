using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApiClient
{
    public class RouteBuilder
    {
        public ApiPrefixes prefixes { get; set; }

        public ApiSuffixes suffixes { get; set; }

        public List<string> AllRoutes { get; private set; }


        public RouteBuilder()
        {
            prefixes = new ApiPrefixes();
            suffixes = new ApiSuffixes();
        }
    }
}
