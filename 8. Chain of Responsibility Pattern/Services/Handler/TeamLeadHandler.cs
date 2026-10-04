public class TeamLeadHandler : ExpenseHandler
{
    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= 1000)
        {
            Console.WriteLine($"Team Lead approved the expense request of {request.Amount:C}.");
        }
        else
        {
            Console.WriteLine($"Team Lead cannot approve the expense request of {request.Amount:C}. Passing to next handler.");
            _nextHandler?.Handle(request);
        }
    }
}
