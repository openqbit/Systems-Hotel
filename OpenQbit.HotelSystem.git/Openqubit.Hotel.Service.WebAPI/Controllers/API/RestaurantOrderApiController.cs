using Openqubit.Hotel.Service.WebAPI.Models.API;
using OpenQubit.Hotel.BLL.BusinessService.Contracts.Orders;
using OpenQubit.Hotel.Common.Ioc;
using OpenQubit.Hotel.Common.Models;
using OpenQubit.Hotel.Common.Models.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Openqubit.Hotel.Service.WebAPI.Controllers.API
{
    public class RestaurantOrderApiController : ApiController
    {
        public bool Add(RestaurantOrderApiModel restaurantOrdermodel)
        {
            IRestaurantOrderManager restaurantOrder = UnityResolver.Resolve<IRestaurantOrderManager>();


            RestaurantOrder order = new RestaurantOrder
            {
                EmployeeID = restaurantOrdermodel.EmployeeID,
                CustomerID = restaurantOrdermodel.CustomerID,
                OrderID = restaurantOrdermodel.OrderID,
                OrderDate = restaurantOrdermodel.OrderDate,
                OrderType = restaurantOrdermodel.OrderType,
                ReataurantOrderDetailModel = restaurantOrdermodel.ReataurantOrderDetail,
                Qty = restaurantOrdermodel.Qty,
                ItemId = restaurantOrdermodel.ItemId,
                OrderTypeID = restaurantOrdermodel.OrderTypeID

            };

            return restaurantOrder.RecordRestaurantOrder(order);
        }

        public List<ApiCustomerModel> GetList()
        {
            List<ApiCustomerModel> customerList = new List<ApiCustomerModel>();

            ApiCustomerModel customer1 = new ApiCustomerModel
            {
                ID = 1,
                Name = "Abc",
                Address = "Colombo",
                Tel = "094",
                Creditlimit = 2000
            };

            ApiCustomerModel customer2 = new ApiCustomerModel
            {
                ID = 2,
                Name = "Bcd",
                Address = "Panadura",
                Tel = "094",
                Creditlimit = 2500
            };

            customerList.Add(customer1);
            customerList.Add(customer2);

            return customerList;
        }
    }
}
