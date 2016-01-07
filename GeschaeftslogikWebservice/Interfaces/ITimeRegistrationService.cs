using Projektarbeit.DatenhaltungEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projektarbeit.DatenhaltungSerialisierung.Model;

namespace Projektarbeit.GeschaeftslogikWebservice.Interfaces
{
    [ServiceContract]
    public class ITimeRegistrationService
    {
        [OperationContract]
        IWorkTime UpdateWorkTime(String userMail, IWorkTime workTime, String projectDescription);

        [OperationContract]
        List<IWorkTime> GetMyTimesForProject(String userMail, String projectName);

        [OperationContract]
        Dictionary<String, List<IWorkTime>> GetMyWorkTimes(String userMail);

        [OperationContract]
        List<IProject> GetMyProjects(String userMail);
    }
}