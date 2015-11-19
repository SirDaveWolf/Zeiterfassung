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
        [DataContract]
        Boolean UpdateUser ( User user );
        [DataContract]
        Boolean DeleteUser ( User user );
        [DataContract]
        Boolean UpdateProject ( Project project );
        [DataContract]
        Boolean DeleteProject ( Project project );
        [DataContract]
        Boolean PermitUserForProject ( String mail, String projectName );
        [DataContract]
        Boolean DenyUserForProject ( String mail, String projectName );
        [DataContract]
        List<User> GetUsers ();
        [DataContract]
        List<Project> GetProjects ();
    }
}
