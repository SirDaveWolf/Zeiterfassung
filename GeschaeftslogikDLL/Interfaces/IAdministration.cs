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
        bool UpdateUser(User user);
        bool DeleteUser(User user);
        bool UpdateProject(Project project);
        bool DeleteProject(Project project);
    }
}
