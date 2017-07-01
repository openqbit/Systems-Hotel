using OpenQubit.Hotel.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.BLL.BusinessService.Contracts.Orders
{
    public interface IRestaurantOrderManager
    {
        bool RecordRestaurantOrder(Order order);
        bool ModifyRestaurantOrder(Order order);

        bool RemoveRestaurantOrder(Order order);
    }
}
