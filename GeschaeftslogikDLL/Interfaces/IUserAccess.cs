using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.GeschaeftslogikDLL.Interfaces
{
    public interface IUserAccess
    {
        Guid Login(String mail, String password);

        Boolean Logout(Guid userIdentification);
    }
}
