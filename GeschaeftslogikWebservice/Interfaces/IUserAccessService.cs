using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Projektarbeit.GeschaeftslogikWebservice.Interfaces
{
    [ServiceContract]
    public interface IUserAccessService
    {
        [OperationContract]
        Guid Login(String username, String password);

        [OperationContract]
        Boolean Logout(Guid userIdentification);
    }
}
