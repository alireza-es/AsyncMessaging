using System.Threading.Tasks;

namespace AsyncMessaging.Core
{
    public interface IClient
    {
        Task<IResponseMessage> SendAsync(IRequestMessage requestMessage);
        Task<TResponseMessage> SendAsync<TResponseMessage>(IRequestMessage requestMessage)
            where TResponseMessage : IResponseMessage;
    }
}
