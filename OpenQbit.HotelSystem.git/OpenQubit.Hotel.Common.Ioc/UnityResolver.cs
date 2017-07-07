using Microsoft.Practices.Unity;
using OpenQubit.Hotel.BLL.BusinessService.Contracts.Orders;
using OpenQubit.Hotel.BLL.BusinessService.Orders;
using OpenQubit.Hotel.Common.Utils.Logs;
using OpenQubit.Hotel.DAL.DataAccess;
using OpenQubit.Hotel.DAL.DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Ioc
{
    public static class UnityResolver
    {
        private static readonly IUnityContainer Container = new UnityContainer();

        public static void Register()
        {
            Container.RegisterType<IRepository, Repository>();
            Container.RegisterType<ILogger, Logger>();
            Container.RegisterType<IBarOrderManager, BarOrderManager>();
            Container.RegisterType<IRestaurantOrderManager, RestaurantOrderManager>();
            Container.RegisterType<IRoomOrderManager, RoomOrderManager>();
        }

        public static T Resolve<T>()
        {
            T defaultT = default(T);
            var resolved = Container.Resolve<T>();
            return (resolved == null) ? defaultT : resolved;
        }

        public static IUnityContainer GetContainer()
        {
            return Container;
        }
    }
}
