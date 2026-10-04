public class Order
{
    private IOrderState _state;

    public Order()
    {
        _state = new PendingState();
    }

    public void SetState(IOrderState state)
    {
        _state = state;
    }

    public void Confirm()
    {
        _state.Confirm(this);
    }

    public void Ship()
    {
        _state.Ship(this);
    }

    public void Cancel()
    {
        _state.Cancel(this);
    }

}