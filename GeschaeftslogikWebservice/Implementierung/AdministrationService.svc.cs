using Projektarbeit.GeschaeftslogikWebservice.Interfaces;
using Projektarbeit.DatenhaltungSerialisierung.Utilities;
using Projektarbeit.DatenhaltungSerialisierung.Model;
using Projektarbeit.DatenhaltungEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Projektarbeit.GeschaeftslogikWebservice.Implementierung
{
    public class AdministrationService : IAdministrationService
    {

        private
        IDataFileManagement dataManagement;

        public AdministrationService ( DataManagementType type )
        {
            if ( type == DataManagementType.EntityFramework )
                dataManagement = new EFWrapper();

            if ( type == DataManagementType.Json )
                dataManagement = new DataFileManagement();
        }
        public bool UpdateUser ( IUser user )
        {
            return dataManagement.WriteUser(user);
        }

        public bool DeleteUser ( IUser user )
        {
            return dataManagement.DeleteUser(user.EMail);
        }

        public bool UpdateProject ( IProject project )
        {
            return dataManagement.WriteProject(project);
        }

        public bool DeleteProject ( IProject project )
        {
            return dataManagement.DeleteProject(project.Kurzbeschreibung);
        }

        public bool PermitUserForProject ( string mail, string projectName )
        {
            return dataManagement.PermitUserToProject(mail, projectName);
        }

        public bool DenyUserForProject ( string mail, string projectName )
        {
            return dataManagement.DenyUserToProject(mail, projectName);
        }

        public List<IUser> GetUsers ()
        {
            return dataManagement.GetAllUsers();
        }

        public List<IProject> GetProjects ()
        {
            return dataManagement.GetAllProjects();
        }
    }
}
