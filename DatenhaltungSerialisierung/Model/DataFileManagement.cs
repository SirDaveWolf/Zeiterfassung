using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungSerialisierung.Model
{
    public class DataFileManagement : IDataFileManagement
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
    }
}
