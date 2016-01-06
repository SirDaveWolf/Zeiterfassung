using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungEF.Model
{
    public class Database : DbContext 
    {
        public
        Database ()
            : base( "DatenbankConnectionString" )
        {
        }

        public virtual
        DbSet<User> Users { get; set; }

        public virtual
        DbSet<Project> Projects { get; set; }

        public virtual
        DbSet<WorkTime> WorkTimes { get; set; }
    }
}
