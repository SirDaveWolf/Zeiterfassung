using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungSerialisierung.Model
{
    public interface IWorkTime
    {
        public
        Guid Id { get; set; }

        public
        Single Anfang { get; set; }

        public
        Single Ende { get; set; }

        public
        Boolean IstAbrechenbar { get; set; }

        public
        Boolean IstReisezeit { get; set; }
    }
}
