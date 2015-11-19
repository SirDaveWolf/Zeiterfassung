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
        public bool UpdateUser(DatenhaltungEF.Model.User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(DatenhaltungEF.Model.User user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProject(DatenhaltungEF.Model.Project project)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProject(DatenhaltungEF.Model.Project project)
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
