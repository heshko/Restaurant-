using System;
using System.Threading;

namespace Restaurant.Domain
{
    class Jeff : ICook
    {
        public string Name { get; } = "Jeff";

        public void Cook(Order order)
        {
            order.Started();

            Thread.Sleep(5000);

            order.Completed();
        }
    }
}
