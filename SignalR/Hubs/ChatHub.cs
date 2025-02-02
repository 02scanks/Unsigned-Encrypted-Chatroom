﻿using Microsoft.AspNetCore.SignalR;
namespace SignalR.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);   // Will message whoever is connected to the hub
    }

}
