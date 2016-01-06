using Projektarbeit.DatenhaltungEF.Model;
using Projektarbeit.DatenhaltungSerialisierung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.GeschaeftslogikDLL.Interfaces
{
    public interface IAdministration
    {
        Boolean UpdateUser ( IUser user );
        Boolean DeleteUser ( IUser user );
        Boolean UpdateProject ( IProject project );
        Boolean DeleteProject ( IProject project );
        Boolean PermitUserForProject ( String mail, String projectName );
        Boolean DenyUserForProject ( String mail, String projectName );
        List<IUser> GetUsers ();
        List<IProject> GetProjects ();
    }
}
