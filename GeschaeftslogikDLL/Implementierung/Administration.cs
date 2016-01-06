using Projektarbeit.DatenhaltungEF.Model;
using Projektarbeit.DatenhaltungSerialisierung.Model;
using Projektarbeit.DatenhaltungSerialisierung.Utilities;
using Projektarbeit.GeschaeftslogikDLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.GeschaeftslogikDLL.Implementierung
{
    public class Administration : IAdministration
    {
        private
        IDataFileManagement dataManagement;

        public Administration ( DataManagementType type )
        {
            if ( type == DataManagementType.EntityFramework )
                dataManagement = new EFWrapper();

            if ( type == DataManagementType.Json )
                dataManagement = new DataFileManagement();
        }

        public bool UpdateUser ( IUser user )
        {
            return dataManagement.WriteUser( user );
        }

        public bool DeleteUser ( IUser user )
        {
            return dataManagement.DeleteUser( user.EMail );
        }

        public bool UpdateProject ( IProject project )
        {
            return dataManagement.WriteProject( project );
        }

        public bool DeleteProject ( IProject project )
        {
            return dataManagement.DeleteProject( project.Kurzbeschreibung );
        }


        public bool PermitUserForProject ( string mail, string projectName )
        {
            return true;
        }

        public bool DenyUserForProject ( string mail, string projectName )
        {
            throw new NotImplementedException();
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
