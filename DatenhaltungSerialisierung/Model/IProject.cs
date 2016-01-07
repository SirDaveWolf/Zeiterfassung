using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungSerialisierung.Model
{
    public interface IProject
    {
        
        String Bezeichnung { get; set; }

        
        String Kurzbeschreibung { get; set; }

        
        Single MaxStundensatz { get; set; }
    }
}
