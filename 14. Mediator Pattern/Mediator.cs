public class Mediator : IMediator
{
    private readonly Dictionary<Type, object> _handlers;

    public Mediator(
        Dictionary<Type, object> handlers)
    {
        _handlers = handlers;
    }

    public void Send<TRequest>(TRequest request)
        where TRequest : IRequest
    {
        var requestType = typeof(TRequest);

        if (!_handlers.TryGetValue(
                requestType,
                out var handlerObject))
        {
            throw new Exception(
                $"No handler found for {requestType.Name}");
        }

        var handler =
            (IRequestHandler<TRequest>)handlerObject;

        handler.Handle(request);
    }
}