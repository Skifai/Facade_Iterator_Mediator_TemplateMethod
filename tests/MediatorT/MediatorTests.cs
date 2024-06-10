using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Mediator;

namespace DesignPatterns.Tests.MediatorT
{
    public class MediatorTests
    {
        public static void Main(string[] args)
        {
            TestUserMessaging();
            TestAdminMessaging();
            TestAdminSystemMessaging();
        }

        private static void TestUserMessaging()
        {
            IChatRoomMediator chatRoom = new ChatRoom();

            User alice = new User("Alice", chatRoom);
            User bob = new User("Bob", chatRoom);

            Console.WriteLine("Test: User Messaging");
            alice.Send("Hi everyone!");
            bob.Send("Hello Alice!");
            Console.WriteLine();
        }

        private static void TestAdminMessaging()
        {
            IChatRoomMediator chatRoom = new ChatRoom();

            User alice = new User("Alice", chatRoom);
            Admin admin = new Admin("Admin", chatRoom);

            Console.WriteLine("Test: Admin Messaging");
            alice.Send("Hi Admin!");
            admin.Send("Welcome Alice!");
            Console.WriteLine();
        }

        private static void TestAdminSystemMessaging()
        {
            IChatRoomMediator chatRoom = new ChatRoom();

            Admin admin = new Admin("Admin", chatRoom);

            Console.WriteLine("Test: Admin System Messaging");
            admin.SendSystemMessage("This is a system message.");
            Console.WriteLine();
        }
    }
}
