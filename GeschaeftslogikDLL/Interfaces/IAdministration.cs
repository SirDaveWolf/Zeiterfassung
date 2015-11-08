using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektarbeit.DatenhaltungEF.Model;

namespace Projektarbeit.GeschaeftslogikDLL.Interfaces
{
    public interface IAdministration
    {
        Boolean UpdateUser(User user);
        Boolean DeleteUser(User user);
        Boolean UpdateProject(Project project);
        Boolean DeleteProject(Project project);
        Boolean PermitUserForProject(String mail, String projectName);
        Boolean DenyUserForProject(String mail, String projectName);
        List<User> GetUsers();
        List<Project> GetProjects();

    }
}
