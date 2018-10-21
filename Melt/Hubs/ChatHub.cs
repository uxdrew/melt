using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Melt.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.Others.SendAsync("ReceiveMessage", message);
        }
    }
}