﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.GeschaeftslogikDLL.Interfaces
{
    public interface IAdministration
    {
        bool UpdateUser<T>(T newUser);
        bool DeleteUser<T>(T changedUser);
    }
}