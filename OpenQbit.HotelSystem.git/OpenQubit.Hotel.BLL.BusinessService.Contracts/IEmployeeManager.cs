using OpenQubit.Hotel.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.BLL.BusinessService.Contracts
{
    public interface IEmployeeManager
    {
        bool RecordEmployee(Employee employee);
        bool ModifyEmployee(Employee employee);
        bool RemoveEmployee(Employee employee);
        Employee FindById(int id);
        Employee Find(Expression<Func<Employee, bool>> predicate);

        List<Employee> FindByEmployeeType(int employeetypeid);
       

    }
}
