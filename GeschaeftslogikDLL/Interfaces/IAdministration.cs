using Projektarbeit.DatenhaltungEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.GeschaeftslogikDLL.Interfaces
{
    public interface IAdministration
    {
        Boolean UpdateUser(User user);
        Boolean DeleteUser(User user);
        Boolean UpdateProject(Project project);
        Boolean DeleteProject(Project project);
    }
}
