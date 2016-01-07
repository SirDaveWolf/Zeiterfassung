using Projektarbeit.DatenhaltungEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projektarbeit.DatenhaltungSerialisierung.Model;

namespace Projektarbeit.GeschaeftslogikWebservice.Interfaces
{
    [ServiceContract]
    public interface IAdministrationService
    {
        [OperationContract]
        IUser UpdateUser ( IUser user );
        [OperationContract]
        IUser DeleteUser ( IUser user );
        [OperationContract]
        IProject UpdateProject ( IProject project );
        [OperationContract]
        IProject DeleteProject ( IProject project );
        [OperationContract]
        IUser PermitUserForProject ( String mail, String projectName );
        [OperationContract]
        IUser DenyUserForProject ( String mail, String projectName );
        [OperationContract]
        List<IUser> GetUsers ();
        [OperationContract]
        List<IProject> GetProjects ();
    }
}
