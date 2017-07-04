
using OpenQubit.Hotel.BLL.BusinessService.Contracts.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Hotel.Common.Models;
using OpenQubit.Hotel.Common.Utils.Logs;
using OpenQubit.Hotel.DAL.DataAccess.Contracts;

namespace OpenQubit.Hotel.BLL.BusinessService.Orders
{
    public class BarOrderManager : IBarOrderManager

    {
        private ILogger log;
        private IRepository repository;

        public BarOrderManager(IRepository repository,ILogger log) {
            this.log = log;
            this.repository = repository;

        }
        public List<Order> FindByDate(DateTime datetime)
        {
            return repository.FindList<Order>(o => o.OrderDate == datetime);
        }

        public Order FindById(int id)
        {
            return repository.Find<Order>(o=>o.OrderID==id);
            //throw new NotImplementedException();
        }

        public List<Order> FindByOrderType(int ordertypeid)
        {
            return repository.FindList<Order>(o => o.OrderTypeID == ordertypeid);
           // throw new NotImplementedException();
        }

      

        public bool ModifyBarOrder(Order order)
        {
            return repository.Update<Order>(order);
           // throw new NotImplementedException();
        }

        public bool RecordBarOrder(Order order)
        {
            return repository.Create<Order>(order);
           // throw new NotImplementedException();
        }

        public bool RemoveBarOrder(Order order)
        {
            return repository.Delete<Order>(order);
           // throw new NotImplementedException();
        }
    }
}
