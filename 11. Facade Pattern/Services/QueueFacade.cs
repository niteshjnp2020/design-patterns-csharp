public class QueueFacade
{
    private readonly QueueService _queueService;
    private readonly CustomerService _customerService;
    private readonly TokenService _tokenService;
    private readonly NotificationService _notificationService;

    public QueueFacade(
        CustomerService customerService,
        QueueService queueService,
        TokenService tokenService,
        NotificationService notificationService)
    {
        _customerService = customerService;
        _queueService = queueService;
        _tokenService = tokenService;
        _notificationService = notificationService;
    }

    public string GenerateToken(int customerId, int branchId)
    {
        var customer =
            _customerService.GetCustomer(customerId);

        var available =
            _queueService.HasCapacity(branchId);

        if (!available)
            throw new Exception("Queue is full.");

        var token =
            _tokenService.GenerateToken();

        _notificationService.Send(token);

        return token;
    }
}