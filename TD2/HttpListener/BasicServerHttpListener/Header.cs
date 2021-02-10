using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace BasicServerHTTPlistener
{
    class Header {
        private HttpListenerRequest request;
        public Header(HttpListenerRequest request) {
            this.request = request;
        }

        public void toString() {
            System.Collections.Specialized.NameValueCollection headers = request.Headers;
            foreach (string key in headers.AllKeys) {
                string[] values = headers.GetValues(key);
                if (values.Length > 0) {
                    Console.WriteLine("Les valeurs de l'header {0} sont : ", key);
                    foreach (string value in values)
                    {
                        Console.WriteLine("    {0}", value);
                    }
                }
            }
        }
    }
}
