using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class User
    {
        protected string _name;
        protected IChatRoomMediator _chatRoom;

        public User(string name, IChatRoomMediator chatRoom)
        {
            _name = name;
            _chatRoom = chatRoom;
        }

        public string GetName()
        {
            return _name;
        }

        public void Send(string message)
        {
            _chatRoom.ShowMessage(this, message);
        }
    }

}
