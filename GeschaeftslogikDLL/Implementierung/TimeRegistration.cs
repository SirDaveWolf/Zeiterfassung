using Projektarbeit.DatenhaltungEF.Model;
using Projektarbeit.DatenhaltungSerialisierung.Model;
using Projektarbeit.DatenhaltungSerialisierung.Utilities;
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
        private
        IDataFileManagement dataManagement;

        public TimeRegistration ( DataManagementType type )
        {
            if ( type == DataManagementType.EntityFramework )
                dataManagement = new EFWrapper();

            if ( type == DataManagementType.Json )
                dataManagement = new DataFileManagement();
        }

        public bool UpdateWorkTime ( Guid userIdentification, IWorkTime workTime, int projectID )
        {
            throw new NotImplementedException();
        }

        public List<IWorkTime> GetMyTimesForProject ( Guid userIdentification, string projectName )
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, List<IWorkTime>> GetMyWorkTimes ( Guid userIdentification )
        {
            throw new NotImplementedException();
        }

        public List<IProject> GetMyProjects ( Guid userIdentification )
        {
            throw new NotImplementedException();
        }
    }
}
