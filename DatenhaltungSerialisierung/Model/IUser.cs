using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungSerialisierung.Model
{
    public interface IUser
    {
        public
        Guid Id { get; set; }

        public
        String Name { get; set; }

        public
        String Vorname { get; set; }

        public
        String EMail { get; set; }

        public
        String Passwort { get; set; }

        public
        Single MinArbeitszeit { get; set; }

        public
        Boolean IstAdmin { get; set; }
    }
}
