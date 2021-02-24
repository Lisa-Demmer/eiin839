using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsStation
{
    class Station
    {
        public int number { get; set; }
        public string contractName { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Position position { get; set; }

        public override string ToString()
        {
            return "Station : " + name + "\n" +
                " number = " + number + "\n" +
                " contractName = " + contractName + "\n" +
                " address = " + address + "\n" +
                " position = [" + position + "]\n";
        }
    }

    class Position
    {
        public float latitude { get; set; }
        public float longitude { get; set; }

        public override string ToString()
        {
            return "latitude : " + latitude + " longitude : " + longitude;
        }
    }
}
