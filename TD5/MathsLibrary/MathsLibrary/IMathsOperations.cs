using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathsLibrary
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IMathsOperations
    {
        [OperationContract]
        int Add(int valueA, int valueB);

        [OperationContract]
        int Multiply(int valueA, int valueB);

        [OperationContract]
        int Substract(int valueA, int valueB);

        [OperationContract]
        double Divide(int valueA, int valueB);

        // TODO: ajoutez vos opérations de service ici
    }
}
