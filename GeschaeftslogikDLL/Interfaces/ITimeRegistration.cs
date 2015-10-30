using Projektarbeit.DatenhaltungEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.GeschaeftslogikDLL.Interfaces
{
    public interface ITimeRegistration
    {
        Boolean UpdateWorkTime(Guid userIdentification, WorkTime workTime, Int32 projectID );

        List<Project> GetMyProjects(Guid userIdentification);
    }
}
