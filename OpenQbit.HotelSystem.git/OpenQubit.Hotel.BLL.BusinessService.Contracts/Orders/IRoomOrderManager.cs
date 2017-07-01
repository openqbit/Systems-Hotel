using OpenQubit.Hotel.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.BLL.BusinessService.Contracts.Orders
{
    public interface IRoomOrderManager
    {
        bool RecordRoomOrder(Order order);

        bool ModifyRoomOrder(Order order);

        bool RemoveRoomOrder(Order order);
    }
}
