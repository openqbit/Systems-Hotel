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
        public bool ModifyRoomOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public bool RecordRoomOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public bool RemoveRoomOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
