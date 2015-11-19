using Projektarbeit.DatenhaltungEF.Model;
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
        Boolean UpdateUser ( User user );

        [OperationContract]
        Boolean DeleteUser ( User user );

        [OperationContract]
        Boolean UpdateProject ( Project project );

        [OperationContract]
        Boolean DeleteProject ( Project project );
    }
}
