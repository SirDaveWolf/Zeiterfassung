using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotaions;

namespace Projektarbeit.DatenhaltungEF.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
    }
}
