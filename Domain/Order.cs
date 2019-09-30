using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Domain
{
    class Order
    {
        protected internal string Dish { get; }
        protected internal string Table { get; }
        protected internal DateTime RegisteredAt { get; } = DateTime.Now;
        protected internal DateTime? StartedAt { get; }
        protected internal DateTime? CompletedAt { get; }


        public Order(string dish,string table)
        {
            Dish = dish;
            Table = table;
            //RegisteredAt = DateTime.Now;
        }

    }
}
