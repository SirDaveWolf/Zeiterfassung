using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungSerialisierung.Model
{
    public interface IUser
    {
        
        String Name { get; set; }

        
        String Vorname { get; set; }

        
        String EMail { get; set; }

        
        String Passwort { get; set; }

        
        Single MinArbeitszeit { get; set; }

        
        Boolean IstAdmin { get; set; }
    }
}
