public interface IMediator
{
   public void Send<TRequest>(TRequest request) where TRequest : IRequest;
}