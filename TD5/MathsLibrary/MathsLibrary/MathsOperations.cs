﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathsLibrary
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class MathsOperations : IMathsOperations
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public int Add(int valueA, int valueB)
        {
            return valueA + valueB;
        }

        public int Multiply(int valueA, int valueB)
        {
            return valueA * valueB;
        }

        public int Substract(int valueA, int valueB)
        {
            return valueA - valueB;
        }

        public double Divide(int valueA, int valueB)
        {
            if (valueB == 0) return 0;
            return valueA / valueB;
        }
    }
}
