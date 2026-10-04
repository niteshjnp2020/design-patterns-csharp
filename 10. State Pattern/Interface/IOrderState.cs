public interface IOrderState
{
    void Confirm(Order order);
    void Ship(Order order);
    void Cancel(Order order);
}