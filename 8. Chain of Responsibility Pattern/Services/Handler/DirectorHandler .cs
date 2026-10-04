public class DirectorHandler : ExpenseHandler
{
    public override void Handle(ExpenseRequest request)
    {
        Console.WriteLine("Director approved.");
    }
}