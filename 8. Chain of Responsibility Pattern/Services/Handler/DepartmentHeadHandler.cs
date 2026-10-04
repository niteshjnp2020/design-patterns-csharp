public class DepartmentHeadHandler : ExpenseHandler
{
    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= 1000)
        {
            Console.WriteLine($"Department Head approved the expense request of {request.Amount:C}.");
        }
        else
        {
            Console.WriteLine($"Department Head cannot approve the expense request of {request.Amount:C}. Passing to next handler.");
            _nextHandler?.Handle(request);
        }
    }
}