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

        public Guid Login(String mail, String password)
        {
            throw new NotImplementedException();
        }

        public Boolean Logout(Guid userIdentification)
        {
            throw new NotImplementedException();
        }
    }
}
