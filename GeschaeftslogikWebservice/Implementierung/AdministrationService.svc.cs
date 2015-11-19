using Projektarbeit.GeschaeftslogikWebservice.Interfaces;
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
        public bool UpdateUser ( DatenhaltungEF.Model.User user )
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser ( DatenhaltungEF.Model.User user )
        {
            throw new NotImplementedException();
        }

        public bool UpdateProject ( DatenhaltungEF.Model.Project project )
        {
            throw new NotImplementedException();
        }

        public bool DeleteProject ( DatenhaltungEF.Model.Project project )
        {
            throw new NotImplementedException();
        }

        public bool PermitUserForProject ( string mail, string projectName )
        {
            throw new NotImplementedException();
        }

        public bool DenyUserForProject ( string mail, string projectName )
        {
            throw new NotImplementedException();
        }

        public List<DatenhaltungEF.Model.User> GetUsers ()
        {
            throw new NotImplementedException();
        }

        public List<DatenhaltungEF.Model.Project> GetProjects ()
        {
            throw new NotImplementedException();
        }
    }
}
