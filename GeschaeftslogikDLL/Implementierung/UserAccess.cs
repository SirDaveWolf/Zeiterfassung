﻿using Projektarbeit.DatenhaltungEF.Model;
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
    public class UserAccess : IUserAccess
    {
        private
        IDataFileManagement dataManagement;

        public UserAccess ( DataManagementType type )
        {
            if ( type == DataManagementType.EntityFramework )
                dataManagement = new EFWrapper();

            if ( type == DataManagementType.Json )
                dataManagement = new DataFileManagement();
        }

        public IUser Login(String mail, String password)
        {
            throw new NotImplementedException();
        }

        public Boolean Logout(String EMail)
        {
            return true;
        }
    }
}
