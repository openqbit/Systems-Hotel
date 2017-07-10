using System;
using OpenQubit.Hotel.Common.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace OpenQubit.Hotel.BLL.BusinessService.Contracts
{
    public interface IItemManager
    {
        bool RecordItem(Item item);
        bool ModifyItem(Item item);
        bool RemoveItem(Item item);
        Item FindById(int id);
        Item Find(Expression<Func<Item, bool>> predicate);

        List<Item> FindByItemType(int itemid);
       
    }
}
