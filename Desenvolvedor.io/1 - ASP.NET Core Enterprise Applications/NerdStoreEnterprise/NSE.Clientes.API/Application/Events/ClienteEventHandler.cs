﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace NSE.Clientes.API.Application.Events
{
    public class ClienteEventHandler : INotificationHandler<ClienteRegistradoEvent>
    {
        public Task Handle(ClienteRegistradoEvent notification, CancellationToken cancellationToken)
        {
            //Enviar um evento de confirmação
            return Task.CompletedTask;
        }
    }
}