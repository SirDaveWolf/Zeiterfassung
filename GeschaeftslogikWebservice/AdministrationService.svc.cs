using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Projektarbeit
{
    public class AdministrationService : IAdministrationService
    {
        public bool UpdateUser<T>(T newUser)
        {
            return true;
        }

        public bool DeleteUser<T>(T changedUser)
        {
            return true;
        }
    }
}
