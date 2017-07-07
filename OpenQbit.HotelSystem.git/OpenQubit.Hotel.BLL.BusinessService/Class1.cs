using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.BLL.BusinessService
{
    class Class1
    {
        private void abc()
        {
            EmployeeManager em = new EmployeeManager();

            Employee empl = em.Find(E => E.JobType.Title == "");

        }

    }
}
