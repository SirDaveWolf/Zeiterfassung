using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungSerialisierung.Model
{
    public class DataFileManagement
    {
        private List<User> UserList { get; set; }
        private List<Project> ProjectList { get; set; }
        private List<WorkTime> WorkTimeList { get; set; }

        public DataFileManagement()
        {
            UserList = new List<User>();
            ProjectList = new List<Project>();
            WorkTimeList = new List<WorkTime>();
        }

        public Boolean LeseUser()
        {
            return true;
        }

        public Boolean LeseProject()
        {
            return true;
        }

        public Boolean LeseWorkTime()
        {
            return true;
        }

        public Boolean SchreibeUser()
        {
            return true;
        }

        public Boolean SchreibeProject()
        {
            return true;
        }

        public Boolean SchreibeWorkTime()
        {
            return true;
        }

        public Boolean LöscheUser() 
        {
            return true;
        }

        public Boolean LöscheProject()
        {
            return true;
        }

    }
}
