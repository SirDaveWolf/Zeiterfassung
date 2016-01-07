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

        public bool UpdateWorkTime ( string userMail, IWorkTime workTime, string projectDescription )
        {
            return dataManagement.AssignWorkTimeToUser( userMail, workTime.Id, projectDescription );
        }

        public Dictionary <string, List<IWorkTime>> GetMyTimesForProject ( string userMail, string projectName )
        {
            return dataManagement.GetMyTimesForProject( userMail, projectName );
        }
     
        public Dictionary<string, List<IWorkTime>> GetMyWorkTimes ( string userMail )
        {
            throw new NotImplementedException();
        }

        public List<IProject> GetMyProjects ( string userMail )
        {
            throw new NotImplementedException();
        }

        List<IWorkTime> ITimeRegistration.GetMyTimesForProject(string userMail, string projectName)
        {
            throw new NotImplementedException();
        }
    }
}
