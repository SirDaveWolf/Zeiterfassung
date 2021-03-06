﻿using Projektarbeit.DatenhaltungSerialisierung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungEF.Model
{
    public class EFWrapper : IDataFileManagement, IDisposable
    {
        private Database database = new Database();

        public void Dispose ()
        {
            database.Dispose();
        }

        public IUser ReadUser ( string EMail )
        {
            var user = database.Users.Where( o => o.EMail == EMail ).FirstOrDefault();
            return ( IUser )user;
        }

        public IProject ReadProject ( string description )
        {
            var project = database.Projects.Where( o => o.Kurzbeschreibung == description );
            return ( IProject )project;
        }

        public IWorkTime ReadWorkTime ( int id )
        {
            var workTime = database.WorkTimes.Where( o => o.ID == id ).FirstOrDefault();
            return ( IWorkTime )workTime;
        }

        public bool WriteUser ( IUser user )
        {
            var dbUser = database.Users.Where( o => o.EMail == user.EMail ).FirstOrDefault();

            if ( dbUser != null )
            {
                dbUser.IstAdmin = user.IstAdmin;
                dbUser.MinArbeitszeit = user.MinArbeitszeit;
                dbUser.Name = user.Name;
                dbUser.Passwort = user.Passwort;
                dbUser.Vorname = user.Vorname;

                database.SaveChanges();
                return true;
            }

            database.Users.Add( ( User )user );

            return true;
        }

        public bool WriteProject ( IProject project )
        {
            var pr = database.Projects.Where( o => o.Kurzbeschreibung == project.Kurzbeschreibung ).FirstOrDefault();

            if ( pr != null )
            {
                pr.Bezeichnung = project.Bezeichnung;
                pr.MaxStundensatz = project.MaxStundensatz;
                database.SaveChanges();
                return true;
            }

            database.Projects.Add( ( Project )project );
            database.SaveChanges();
            return true;
        }

        public bool WriteWorkTime ( IWorkTime workTime )
        {
            var wt = database.WorkTimes.Where( o => o.Id == workTime.Id ).FirstOrDefault();

            if ( wt != null )
            {
                wt.IstAbrechenbar = workTime.IstAbrechenbar;
                wt.IstReisezeit = workTime.IstReisezeit;
                wt.Anfang = workTime.Anfang;
                wt.Ende = workTime.Ende;
            }

            database.WorkTimes.Add( ( WorkTime )workTime );
            database.SaveChanges();
            return true;
        }

        public bool DeleteUser ( string EMail )
        {
            var deleteUser = database.Users.Where( o => o.EMail == EMail ).FirstOrDefault();

            if ( deleteUser != null )
            {
                database.Users.Remove( deleteUser );
                database.SaveChanges();
                return true;
            }

            return false;
        }

        public bool DeleteProject ( string description )
        {
            var deleteProject = database.Projects.Where( o => o.Kurzbeschreibung == description ).FirstOrDefault();

            if ( deleteProject != null )
            {
                database.Projects.Remove( deleteProject );
                database.SaveChanges();
                return true;
            }

            return false;
        }


        public List<IUser> GetAllUsers ()
        {
            List<IUser> result = new List<IUser>();

            foreach ( var item in database.Users )
                result.Add( ( IUser )item );

            return result;
        }

        public List<IProject> GetAllProjects ()
        {
            List<IProject> result = new List<IProject>();

            foreach ( var item in database.Projects )
                result.Add( ( IProject )item );

            return result;
        }

        public bool PermitUserToProject ( string EMail, string description )
        {
            var user = database.Users.Where( o => o.EMail == EMail ).FirstOrDefault();
            if ( user == null ) return false;

            var project = database.Projects.Where( o => o.Kurzbeschreibung == description ).FirstOrDefault();
            if ( project == null ) return false;

            if( user.Projects.Contains( project ) ) return false; // Already in relation

            user.Projects.Add( project );
            database.SaveChanges();
            return true;
        }

        public bool DenyUserToProject ( string EMail, string description )
        {
            var user = database.Users.Where( o => o.EMail == EMail ).FirstOrDefault();
            if ( user == null ) return false;

            var project = database.Projects.Where( o => o.Kurzbeschreibung == description ).FirstOrDefault();
            if ( project == null ) return false;

            if ( !user.Projects.Contains( project ) ) return false; // Already denied

            user.Projects.Remove( project );
            database.SaveChanges();
            return true;
        }


        public Dictionary<string, List<IWorkTime>> GetMyTimesForProject(string EMail, string description)
        {
            Dictionary<string, List<IWorkTime>> result = new Dictionary<String, List<IWorkTime>>();

            var workTimes = database.WorkTimes.Where(o => o.User.EMail == EMail);
            var projects = database.Projects.Where(o => o.Kurzbeschreibung == description);

            foreach (var project in projects)
            {
                List<IWorkTime> workTimeList = new List<IWorkTime>();

                foreach (var item in workTimes)
                {
                    if (item.Project.Kurzbeschreibung == project.Kurzbeschreibung)
                    {
                        workTimeList.Add((IWorkTime)item);
                    }
                }

                if (workTimeList.Count > 0)
                    result.Add(project.Kurzbeschreibung, workTimeList);
            }

            return result;
        }

        public bool AssignWorkTimeToUser ( string mail, Guid workTimeID, string projectDescription )
        {
            var user = database.Users.Where( o => o.EMail == mail ).FirstOrDefault();
            if ( user == null ) return false;

            var project = database.Projects.Where( o => o.Kurzbeschreibung == projectDescription ).FirstOrDefault();
            if ( project == null ) return false;

            var workTime = database.WorkTimes.Where( o => o.Id == workTimeID ).FirstOrDefault();

            try
            {
                user.WorkTimes.Add( workTime );
                project.WorkTimes.Add( workTime );
            }
            catch
            {
                return false;
            }

            database.SaveChanges();
            return true;
        }

        public List<IProject> GetMyProjects ( string mail )
        {
            List<IProject> result = new List<IProject>();

            var projects = database.Projects.Where( o => o.Users.Where( u => u.EMail == mail ).FirstOrDefault() != null );
            foreach ( var item in projects )
                result.Add( ( IProject )item );

            return result;
        }

        public List<IWorkTime> GetMyWorkTimes ( string mail, string description )
        {
            var myWorkTimes = database.WorkTimes.Where( o => o.User.EMail == mail && o.Project.Kurzbeschreibung == description );

            List<IWorkTime> result = new List<IWorkTime>();
            foreach ( var item in myWorkTimes )
                result.Add( ( IWorkTime )item );

            return result;
        }

    }
}
