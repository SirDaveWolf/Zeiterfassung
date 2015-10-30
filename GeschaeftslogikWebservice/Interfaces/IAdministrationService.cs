using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Projektarbeit.GeschaeftslogikWebservice.Interfaces
{
    [ServiceContract]
    public interface IAdministrationService
    {
        [OperationContract]
        Boolean UpdateUser<T>(T newUser);

        [OperationContract]
        Boolean DeleteUser<T>(T changedUser);
    }
}
