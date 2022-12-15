using System;
using Microsoft.AspNetCore.SignalR;

namespace Chat.Web.Hubs
{
    public class ChatHub: Hub
    {
        public ChatHub()
        {
        }

        public void Send(string user, string message)
        {
            Clients.Others.SendAsync("Receive", user, message);
        }
    }
}
