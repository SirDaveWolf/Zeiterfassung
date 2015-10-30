using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit
{
    public class ProjectEntry
    {
        public String Name { get; set; }

        public Int32 ID { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
