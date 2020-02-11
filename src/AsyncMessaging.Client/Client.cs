using System.Threading.Tasks;
using AsyncMessaging.Core;

namespace AsyncMessaging.Client
{
    public class Client : IClient
    {
        public Task<IResponseMessage> SendAsync(IRequestMessage requestMessage)
        {
            throw new System.NotImplementedException();
        }

        public Task<TResponseMessage> SendAsync<TResponseMessage>(IRequestMessage requestMessage) where TResponseMessage : IResponseMessage
        {
            throw new System.NotImplementedException();
        }
    }
}
