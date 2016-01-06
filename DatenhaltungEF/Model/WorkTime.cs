using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungEF.Model
{
    public class WorkTime : Entity<Int32>
    {
        public virtual
        User User { get; set; }

        public
        Guid Id { get; set; }

        public
        Boolean IstAbrechenbar { get; set; }

        public
        Boolean IstReisezeit { get; set; }

        public
        DateTime Anfang { get; set; }

        public
        DateTime Ende { get; set; }
    }
}


