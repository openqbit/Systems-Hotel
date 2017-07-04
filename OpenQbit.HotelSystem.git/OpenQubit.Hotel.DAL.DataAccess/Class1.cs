using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQubit.Hotel.Common.Models;

namespace OpenQubit.Hotel.DAL.DataAccess
{
    class Class1
    {

        void test()
        {
            Repository repo = new Repository();

            repo.FindList<Order>(O => O.OrderID == 10);
        }
    }
}
