using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungSerialisierung.Model
{
    public class WorkTime
    {
        public
        Guid Id { get; set; }

        public
        DateTime Anfang { get; set; }

        public
        DateTime Ende { get; set; }

        public
        Boolean IstAbrechenbar { get; set; }

        public
        Boolean IstReisezeit { get; set; }
    }
}
