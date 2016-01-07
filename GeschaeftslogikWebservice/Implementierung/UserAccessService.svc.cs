using Projektarbeit.GeschaeftslogikWebservice.Interfaces;
using Projektarbeit.DatenhaltungSerialisierung.Utilities;
using Projektarbeit.DatenhaltungSerialisierung.Model;
using Projektarbeit.DatenhaltungEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Projektarbeit.GeschaeftslogikWebservice.Implementierung
{
    public class UserAccessService : IUserAccessService
    {
        private
        IDataFileManagement dataManagement;

        public UserAccessService ( DataManagementType type )
        {
            if ( type == DataManagementType.EntityFramework )
                dataManagement = new EFWrapper();

            if ( type == DataManagementType.Json )
                dataManagement = new DataFileManagement();

        }

        public IUser Login(string mail, string password)
        {
            return dataManagement.ReadUser(mail);
        }

        public bool Logout(String EMail)
        {
            return true;
        }
    }

}
