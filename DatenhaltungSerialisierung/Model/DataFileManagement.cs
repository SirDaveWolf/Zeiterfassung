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
            var u = UserList.Where(o => o.EMail == EMail).FirstOrDefault() as IUser;
            return u;
        }

        public IProject ReadProject(string description)
        {
            var sr = File.ReadAllText(pathProject);
            ProjectList=(Jsonizer<List<Project>>.Deserialize(sr));
            var t = ProjectList.Where(o => o.Kurzbeschreibung ==  description).FirstOrDefault() as IProject;
            return t;

        }

        public IWorkTime ReadWorkTime(int id)
        {
            var sr = File.ReadAllText(pathWorkTime);
            WorkTimeList=(Jsonizer<List<WorkTime>>.Deserialize(sr));
            var t = WorkTimeList.Where(o => o.Id.ToString() == id.ToString()).FirstOrDefault() as IWorkTime;
            return t;
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
            List<IUser> result = new List<IUser>();
            var sr = File.ReadAllText(pathUser);
            UserList = (Jsonizer<List<User>>.Deserialize(sr));
            foreach (var item in UserList)
                result.Add((IUser)item);
            
            return result;
    
        }

        public List<IProject> GetAllProjects()
        {
            List<IProject> result = new List<IProject>(); 
            var sr = File.ReadAllText(pathProject);
            ProjectList = (Jsonizer<List<Project>>.Deserialize(sr));
            foreach (var item in UserList)
                result.Add((IProject)item);

            return result;
        }

        public bool PermitUserToProject(string EMail, string description)
        {
            var swU = File.CreateText(pathUser);
            var swP = File.CreateText(pathProject);
            swU.Write(Jsonizer<List<Project>>.Serialize(ProjectList));
            ProjectList.Where(o => o.Bezeichnung == description);
            swP.Write(Jsonizer<List<User>>.Serialize(UserList));
            UserList.Where(o => o.EMail == EMail);
            return true;

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


        Dictionary<string, List<IWorkTime>> IDataFileManagement.GetMyTimesForProject(string EMail, string description)
        {
            throw new NotImplementedException();
        }

        public List<IProject> GetMyProjects(string mail)
        {
            throw new NotImplementedException();
        }

        public List<IWorkTime> GetMyWorkTimes(string mail)
        {
            throw new NotImplementedException();
        }
    }
}
