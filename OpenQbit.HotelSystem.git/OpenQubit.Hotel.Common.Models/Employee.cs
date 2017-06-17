using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        public int JobTypeId { get; set; }

        public virtual Management.JobType JobType { get; set; }

    }
}
