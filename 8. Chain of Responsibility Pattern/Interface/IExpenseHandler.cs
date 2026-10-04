public interface IExpenseHandler
{
    void SetNext(IExpenseHandler nextHandler);
    void Handle(ExpenseRequest request);
}