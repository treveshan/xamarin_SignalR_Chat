using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string message, string color ,string user)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.UpdateChatMessage(message, color,user);
        }
    }
}