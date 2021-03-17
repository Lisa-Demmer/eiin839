using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AuthentifiedAccessSoap
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IAccess
    {
        [OperationContract]
        string Weather(string city);

        // TODO: ajoutez vos opérations de service ici
    }
}
