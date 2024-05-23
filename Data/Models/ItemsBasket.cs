using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ПР37_Осокин.Data.Models
{
    public class ItemsBasket : Items
    {
        public int Count { get; set; }
        public ItemsBasket(int Count, Items items) : base(item)
        {
            this.Count = Count;
        }
    }
}
