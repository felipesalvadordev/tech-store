using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Core.Communication.Mediator;
using MediatR;
using TechStore.Core.Messages.Notifications;
using TechStore.Vendas.Application.Queries;
using TechStore.Venda.Domain;
using TechStore.Vendas.Data;
using TechStore.Vendas.Application.Commands;

namespace TechStore.WebApp.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IPedidosQueries, PedidosQueries>();
            services.AddScoped<VendasContext>();

            services.AddScoped<IRequestHandler<IniciarPedidoCommand, bool>, PedidoCommandHandler>();
        }
    }
}
