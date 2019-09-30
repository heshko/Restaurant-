using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Domain
{
    class Restaurantx
    {

        public string Name { get; set; }
        private Queue<Order> OrderQueue { get; } = new Queue<Order>();

        public Restaurant(string name)
        {
            Name = name;
        }


    }
}
