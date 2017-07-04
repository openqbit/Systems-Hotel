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
    public class RestaurantOrderManager : IRestaurantOrderManager
    {

        private ILogger log;
        private IRepository repository;
        public List<Order> FindByDate(DateTime datetime)
        {
            return repository.FindList<Order>(o=>o.OrderDate==datetime);   
          //  throw new NotImplementedException();
        }

        public Order FindById(int id)
        {
            return repository.Find<Order>(o=>o.OrderID==id);
            //throw new NotImplementedException();
        }

        public List<Order> FindByOrderType(int ordertypeid)
        {
            return repository.FindList<Order>(o =>o.OrderTypeID == ordertypeid);
            //throw new NotImplementedException();
        }

       

        public bool ModifyRestaurantOrder(Order order)
        {
            return repository.Update<Order>(order);
           // throw new NotImplementedException();
        }

        public bool RecordRestaurantOrder(Order order)
        {
            return repository.Create<Order>(order);
           // throw new NotImplementedException();
        }

        public bool RemoveRestaurantOrder(Order order)
        {
            return repository.Delete<Order>(order);
            //throw new NotImplementedException();
        }
    }
}
