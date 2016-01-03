using Projektarbeit.GeschaeftslogikDLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.GeschaeftslogikDLL.Implementierung
{
    public class TimeRegistration : ITimeRegistration
    {
        public bool UpdateWorkTime ( Guid userIdentification, DatenhaltungEF.Model.WorkTime workTime, int projectID )
        {
            throw new NotImplementedException();
        }

        public List<DatenhaltungEF.Model.WorkTime> GetMyTimesForProject ( Guid userIdentification, string projectName )
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, List<DatenhaltungEF.Model.WorkTime>> GetMyWorkTimes ( Guid userIdentification )
        {
            throw new NotImplementedException();
        }

        public List<DatenhaltungEF.Model.Project> GetMyProjects ( Guid userIdentification )
        {
            throw new NotImplementedException();
        }
    }
}
