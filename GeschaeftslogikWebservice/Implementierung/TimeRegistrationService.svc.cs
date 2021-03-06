﻿using Projektarbeit.GeschaeftslogikWebservice.Interfaces;
using Projektarbeit.DatenhaltungSerialisierung.Utilities;
using Projektarbeit.DatenhaltungSerialisierung.Model;
using Projektarbeit.DatenhaltungEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Projektarbeit.GeschaeftslogikWebservice.Implementierung
{

    public class TimeRegistrationService : ITimeRegistrationService
    {

        private
        IDataFileManagement dataManagement;

        public TimeRegistrationService ( DataManagementType type )
        {
            if ( type == DataManagementType.EntityFramework )
                dataManagement = new EFWrapper();

            if ( type == DataManagementType.Json )
                dataManagement = new DataFileManagement();
        }
        public Boolean UpdateWorkTime(String userMail, IWorkTime workTime, String projectDescription)
            {
                return dataManagement.AssignWorkTimeToUser(userMail, workTime.Id, projectDescription);
            }

        public Dictionary <string, List<IWorkTime>> GetMyTimesForProject(String userMail, String projectName)
        {
            return dataManagement.GetMyTimesForProject(userMail, projectName);
        }

        public List<IWorkTime> GetMyWorkTimes(String userMail)
        {
            return dataManagement.GetMyWorkTimes(userMail);
        }

        public List<IProject> GetMyProjects(String userMail)
        {
            return dataManagement.GetMyProjects(userMail);
        }

    }
}
