using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Admin : User
    {
        public Admin(string name, IChatRoomMediator chatRoom) : base(name, chatRoom)
        {
        }

        public void SendSystemMessage(string message)
        {
            string fullMessage = $"[SYSTEM] {message}";
            _chatRoom.ShowMessage(this, fullMessage);
        }
    }
}
