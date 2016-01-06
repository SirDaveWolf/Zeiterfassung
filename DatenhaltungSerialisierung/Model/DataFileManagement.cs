using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektarbeit.DatenhaltungSerialisierung.Utilities;

namespace Projektarbeit.DatenhaltungSerialisierung.Model
{
    public class DataFileManagement : IDataFileManagement

    {
        string pathUser = @"c:\temp\User.json";
        string pathProject = @"c:\temp\Project.json";
        string pathWorkTime = @"c:\temp\WorkTime.json";

        private List<User> UserList { get; set; }
        private List<Project> ProjectList { get; set; }
        private List<WorkTime> WorkTimeList { get; set; }

        public DataFileManagement()
        {
            UserList = new List<User>();
            ProjectList = new List<Project>();
            WorkTimeList = new List<WorkTime>();
        }

        public IUser ReadUser(string EMail)
        {
            var sr = File.ReadAllText(pathUser);
            UserList=(Jsonizer<List<User>>.Deserialize(sr));
            UserList.Where(o => o.EMail == EMail).FirstOrDefault();
        }

        public IProject ReadProject(string description)
        {
            var sr = File.ReadAllText(pathProject);
            ProjectList=(Jsonizer<List<Project>>.Deserialize(sr));
            ProjectList.Where(o => o.Kurzbeschreibung ==  description).FirstOrDefault();
        }

        public IWorkTime ReadWorkTime(int id)
        {
            var sr = File.ReadAllText(pathWorkTime);
            WorkTimeList=(Jsonizer<List<WorkTime>>.Deserialize(sr));
            WorkTimeList.Where(o => o.Id == id).FirstOrDefault();
        }

        public bool WriteUser(IUser user)
        {

            if( File.Exists(pathUser) )
            {
                File.Delete(pathUser);
            }

            var sw = File.CreateText(pathUser);
            sw.Write(Jsonizer<List<User>>.Serialize(UserList));
            sw.Flush();
            sw.Close();
            return true;
        }

        public bool WriteProject(IProject project)
        {

            if( File.Exists(pathProject) )
            {
                File.Delete(pathProject);
            }

            var sw = File.CreateText(pathProject);
            sw.Write(Jsonizer<List<Project>>.Serialize(ProjectList));
            sw.Flush();
            sw.Close();
            return true;
        }

        public bool WriteWorkTime(IWorkTime workTime)
        {
            if( File.Exists(pathWorkTime) )
            {
                File.Delete(pathWorkTime);
            }

            var sw = File.CreateText(pathWorkTime);
            sw.Write(Jsonizer<List<WorkTime>>.Serialize(WorkTimeList));
            sw.Flush();
            sw.Close();
            return true;
        }

        public bool DeleteUser(string EMail)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProject(string description)
        {
            throw new NotImplementedException();
        }

        public List<IUser> GetAllUsers()
        {
            var sr = File.ReadAllText(pathUser);
            UserList = (Jsonizer<List<User>>.Deserialize(sr));
        }

        public List<IProject> GetAllProjects()
        {
            var sr = File.ReadAllText(pathProject);
            ProjectList = (Jsonizer<List<Project>>.Deserialize(sr));
        }

        public bool PermitUserToProject(string EMail, string description)
        {
            throw new NotImplementedException();
        }

        public bool DenyUserToProject(string EMail, string description)
        {
            throw new NotImplementedException();
        }

        public List<IWorkTime> GetMyTimesForProject(string EMail, string description)
        {
            throw new NotImplementedException();
        }

        public bool AssignWorkTimeToUser(string mail, Guid workTimeID, string projectDescription)
        {
            throw new NotImplementedException();
        }
    }
}
