using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungSerialisierung.Model
{
    public interface IDataFileManagement
    {
        IUser ReadUser ( String EMail );

        IProject ReadProject ( String description );

        IWorkTime ReadWorkTime ( Int32 id );

        Boolean WriteUser ( IUser user );

        Boolean WriteProject ( IProject project );

        Boolean WriteWorkTime ( IWorkTime workTime );

        Boolean DeleteUser ( String EMail );

        Boolean DeleteProject ( String description );

        List<IUser> GetAllUsers ();

        List<IProject> GetAllProjects ();

        Boolean PermitUserToProject ( String EMail, String description );

        Boolean DenyUserToProject ( String EMail, String description );


        Dictionary<String, List<IWorkTime>> GetMyTimesForProject ( String EMail, String description );

        Boolean AssignWorkTimeToUser ( String mail, Guid workTimeID, String projectDescription );

        List<IProject> GetMyProjects ( String mail );

        List<IWorkTime> GetMyWorkTimes ( String mail );
    }
}
