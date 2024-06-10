using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class ChatRoom : IChatRoomMediator
    {
        public void ShowMessage(User user, string message)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            var sender = user.GetName();

            Console.WriteLine($"{time} [{sender}]: {message}");
        }
    }

}
