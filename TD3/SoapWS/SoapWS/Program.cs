using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapWS
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceSoap.CalculatorSoap calculator = new ServiceSoap.CalculatorSoapClient();
            int res = calculator.Add(10, 5);
            Console.WriteLine("10 + 5 = {0}", res);
            Console.ReadLine();
        }
    }
}
