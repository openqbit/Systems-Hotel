using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Hotel.Common.Models;

namespace OpenQubit.Hotel.BLL.BusinessService.Contracts.Orders
{
    public interface IBarOrderManager
    {
        bool RecordBarOrder(Order order);
        bool ModifyBarOrder(Order order);

        bool RemoveBarOrder(Order order);

        Order FindById(int id); 

        List<Order> FindByOrderType(int ordertypeid);

      

        List<Order> FindByDate(DateTime datetime);

     


    }
}
