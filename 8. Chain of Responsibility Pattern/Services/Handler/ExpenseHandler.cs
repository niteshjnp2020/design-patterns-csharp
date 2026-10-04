public abstract class ExpenseHandler : IExpenseHandler
{
    protected IExpenseHandler? _nextHandler;

    public void SetNext(IExpenseHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public abstract void Handle(ExpenseRequest request);
}