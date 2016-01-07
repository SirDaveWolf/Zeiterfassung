using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungSerialisierung.Model
{
    public interface IWorkTime
    {
        
        Guid Id { get; set; }

        
        DateTime Anfang { get; set; }

        
        DateTime Ende { get; set; }

        
        Boolean IstAbrechenbar { get; set; }

        
        Boolean IstReisezeit { get; set; }
    }
}
