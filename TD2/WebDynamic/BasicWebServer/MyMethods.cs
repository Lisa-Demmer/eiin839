using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicServerHTTPlistener
{
    class MyMethods
    {
        public string MyMethod(String param1_value, String param2_value)
        {
            return "<HTML><BODY> Hello " + param1_value + " et " + param2_value + "</BODY></HTML>"; 
        }
    }
}
