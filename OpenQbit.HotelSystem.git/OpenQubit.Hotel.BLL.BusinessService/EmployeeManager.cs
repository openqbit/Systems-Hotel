using OpenQubit.Hotel.BLL.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Hotel.Common.Models;
using System.Linq.Expressions;
using OpenQubit.Hotel.DAL.DataAccess.Contracts;
using OpenQubit.Hotel.Common.Utils.Logs;

namespace OpenQubit.Hotel.BLL.BusinessService
{
    public class EmployeeManager : IEmployeeManager
    {
        private IRepository repository;
        private ILogger logger;
        public Employee Find(Expression<Func<Employee, bool>> predicate)
        {
            return repository.Find<Employee>(predicate);
        }


        public List<Employee> FindByEmployeeType(int employeetypeid)
        {
            return repository.FindList<Employee>(e => e.EmployeeId == employeetypeid);
        }

        public Employee FindById(int id)
        {
            return repository.Find<Employee>(e => e.EmployeeId == id);
        }

        public bool ModifyEmployee(Employee employee)
        {
            logger.logError("");
            return repository.Update<Employee>(employee);
        }

        public bool RecordEmployee(Employee employee)
        {
            logger.logError("");
            return repository.Create<Employee>(employee);
        }

        public bool RemoveEmployee(Employee employee)
        {
            logger.logError("");
            return repository.Delete<Employee>(employee);
        }
        
    }
}
