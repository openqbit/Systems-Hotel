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
    public class RoomOrderManager : IRoomOrderManager
    {
        private ILogger log;
        private IRepository repository;

        public List<Order> FindByDate(DateTime datetime)
        {
            return repository.FindList<Order>(O => O.OrderDate == datetime);
           // throw new NotImplementedException();
        }

        public Order FindById(int id)
        {
            return repository.Find<Order>(O=>O.OrderID==id);
            //return repository.Find1<Order>(O =>O.d)
           // throw new NotImplementedException();
        }

        public bool ModifyRoomOrder(Order order)

        {
            return repository.Update<Order>(order);
            //throw new NotImplementedException();
        }

        public bool RecordRoomOrder(Order order)
        {
            return repository.Create<Order>(order);
            //throw new NotImplementedException();
        }

        public bool RemoveRoomOrder(Order order)
        {
            return repository.Delete<Order>(order);
            //throw new NotImplementedException();
        }
    }
}
