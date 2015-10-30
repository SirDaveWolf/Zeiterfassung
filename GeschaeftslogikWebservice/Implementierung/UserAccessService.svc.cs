using Projektarbeit.GeschaeftslogikWebservice.Interfaces;
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
        public Guid Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Logout(Guid userIdentification)
        {
            throw new NotImplementedException();
        }
    }
}
