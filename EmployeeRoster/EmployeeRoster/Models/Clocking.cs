using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRoster.Models
{
    public class Clocking
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public long Duration { get; set; }
    }
}
