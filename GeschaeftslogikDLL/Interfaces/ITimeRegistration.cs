using Projektarbeit.DatenhaltungEF.Model;
using Projektarbeit.DatenhaltungSerialisierung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.GeschaeftslogikDLL.Interfaces
{
    public interface ITimeRegistration
    {
        Boolean UpdateWorkTime(Guid userIdentification, IWorkTime workTime, Int32 projectID );

        List<IWorkTime> GetMyTimesForProject ( Guid userIdentification, String projectName );

        Dictionary<String, List<IWorkTime>> GetMyWorkTimes ( Guid userIdentification );

        List<IProject> GetMyProjects(Guid userIdentification);
    }
}
