﻿using Microsoft.AspNetCore.SignalR;

namespace SignalRApp.Hubs
{
    public class OrderHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
