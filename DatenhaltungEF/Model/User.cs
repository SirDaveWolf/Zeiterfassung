using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Projektarbeit.DatenhaltungEF.Model
{
    public class User : Entity<Int32>
    {
        public
        String Name { get; set; }

        public
        String Vorname { get; set; }

        public
        String EMail { get; set; }

        public
        String Passwort { get; set; }

        public
        Int32 MinArbeitszeit { get; set; }

        public
        Boolean IstAdmin { get; set; }
    }
}
        
