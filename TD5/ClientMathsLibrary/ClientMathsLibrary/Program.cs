using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMathsLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceMathsLibrary.MathsOperationsClient mathsLibrary = new ServiceMathsLibrary.MathsOperationsClient();
            Console.WriteLine(mathsLibrary.Divide(11, 2));
            Console.ReadLine();
        }
    }
}
