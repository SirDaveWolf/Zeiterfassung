using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungSerialisierung.Model
{
    public class Project : IProject
    {
        public
        String Bezeichnung { get; set; }

        public
        String Kurzbeschreibung { get; set; }

        public
        Single MaxStundensatz { get; set; }
    }

}
