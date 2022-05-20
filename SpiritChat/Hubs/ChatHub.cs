using Microsoft.AspNetCore.SignalR;
using SpiritChat.Models;
using System.Threading.Tasks;

namespace SpiritChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) =>
            await Clients.All.SendAsync("recieveMessage", message);
    }
}
