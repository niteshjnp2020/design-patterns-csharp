public interface IRequestHandler<TRequest> where TRequest : IRequest
{
    void Handle(TRequest request);
}