using System;
using System.Threading.Tasks;

namespace EComm.MessageBus
{
    public interface IMessageBus
    {
        Task PublishMessage(BaseMessage message, string topicName);
    }
}
