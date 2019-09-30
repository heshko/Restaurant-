

namespace Restaurant.Domain
{
    interface ICook
    {
        string Name { get; }
        void Cook(Order order);
    }
}
