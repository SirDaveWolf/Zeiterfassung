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
        Boolean UpdateWorkTime(String userMail, IWorkTime workTime, String projectDescription );

        List<IWorkTime> GetMyTimesForProject ( String userMail, String projectName );

        Dictionary<String, List<IWorkTime>> GetMyWorkTimes ( String userMail );

        List<IProject> GetMyProjects ( String userMail );
    }
}
