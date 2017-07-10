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
using Openqubit.Hotel.Service.WebAPI.Mappers;



namespace Openqubit.Hotel.Service.WebAPI.Controllers.API
{
    public class RestaurantOrderApiController : ApiController
    {

        IRestaurantOrderManager restaurantOrder = UnityResolver.Resolve<IRestaurantOrderManager>();
        RestaurantOrder order;
        public bool Add(RestaurantOrderApiModel restaurantOrdermodel)
        {
            

             order = new RestaurantOrder
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

        public List<RestaurantOrderApiModel> GetList()
        {

           return Mappers.ResturantAPIModelMapper.MapOrderModel (restaurantOrder.FindByDate(order.OrderDate));
           // return restaurantOrder.FindByDate(
        }

        public List<RestaurantOrderApiModel> GetOrderTypeList()
        {
            return Mappers.ResturantAPIModelMapper.MapOrderModel(restaurantOrder.FindByOrderType(order.OrderTypeID));
        }

        public bool ModifyRestaurantOrder(RestaurantOrderApiModel restaurantOrdermodel)
        {
            return restaurantOrder.ModifyRestaurantOrder(order);
            // throw new NotImplementedException();
        }

        public bool RemoveRestaurantOrder(RestaurantOrderApiModel restaurantOrdermodel)
        {
            return restaurantOrder.RemoveRestaurantOrder(order);
            // throw new NotImplementedException();
        }

        public Order FindById(RestaurantOrderApiModel restaurantOrdermodel)
        {
            return restaurantOrder.FindById(order.OrderID);
        }

    }
}
