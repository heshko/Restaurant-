﻿using System.Collections.Generic;

namespace Restaurant.Domain
{
    class RestaurantX
    {
        public string Name { get; set; }
        public Queue<Order> OrderQueue { get; } = new Queue<Order>();
      
        public RestaurantX(string name)
        {
            Name = name;
        }

        public void RegisterOrder(Order order)
        {
            OrderQueue.Enqueue(order);
        }
    }
}
