using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OpenQubit.Hotel.Common.Models;
//using OpenQubit.Hotel.Service.WebAPI.Models.API;


namespace Openqubit.Hotel.Service.WebAPI.Mappers
{
    public static class ResturantAPIModelMapper
    {

        public static List<Service.WebAPI.Models.API.RestaurantOrderApiModel> MapOrderModel(List<Order> orderList )
        {

            List<Service.WebAPI.Models.API.RestaurantOrderApiModel> RestaurantOrderApiModelList = new List<Models.API.RestaurantOrderApiModel>();

            foreach ( var orderItem in orderList)
            {
                Service.WebAPI.Models.API.RestaurantOrderApiModel RestaurantOrderApiModel = new Models.API.RestaurantOrderApiModel { CustomerID = orderItem.CustomerID, EmployeeID = orderItem.EmployeeID, Qty = orderItem.Qty,OrderDate = orderItem.OrderDate };
            }


            return RestaurantOrderApiModelList;

        }

    }
}