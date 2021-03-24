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
            MathsLibrary.MathsOperationsClient mathsLibrary1 = new MathsLibrary.MathsOperationsClient("SoapEndPnt1");
            Console.WriteLine("MathLibrary 1 : " + mathsLibrary1.Add(11, 2));
            Console.ReadLine();
            MathsLibrary.MathsOperationsClient mathsLibrary2 = new MathsLibrary.MathsOperationsClient("SoapEndPnt2");
            Console.WriteLine("MathLibrary 2 : " + mathsLibrary2.Divide(11, 2));
            Console.ReadLine();
            MathsLibrary.MathsOperationsClient mathsLibrary3 = new MathsLibrary.MathsOperationsClient("SoapEndPnt3");
            Console.WriteLine("MathLibrary 3 : " + mathsLibrary3.Multiply(11, 2));
            Console.ReadLine();
        }
    }
}
