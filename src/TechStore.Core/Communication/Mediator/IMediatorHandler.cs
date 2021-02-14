using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechStore.Core.Messages;
using TechStore.Core.Messages.DomainEvents;
using TechStore.Core.Messages.Notifications;

namespace TechStore.Core.Communication.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<bool> EnviarComando<T>(T comando) where T : Command;
        Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification;
        Task PublicarDomainEvent<T>(T notificacao) where T : DomainEvent;
    }
}
