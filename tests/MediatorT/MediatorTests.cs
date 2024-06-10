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
        [Fact]
        public void TestUserMessaging()
        {
            // Arrange
            IChatRoomMediator chatRoom = new ChatRoom();
            var alice = new User("Alice", chatRoom);
            var bob = new User("Bob", chatRoom);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            alice.Send("Hi everyone!");
            bob.Send("Hello Alice!");

            // Assert
            var actualOutput = output.ToString();
            Assert.Contains("[Alice]: Hi everyone!", actualOutput);
            Assert.Contains("[Bob]: Hello Alice!", actualOutput);
        }

        [Fact]
        public void TestAdminMessaging()
        {
            // Arrange
            IChatRoomMediator chatRoom = new ChatRoom();
            var alice = new User("Alice", chatRoom);
            var admin = new Admin("Admin", chatRoom);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            alice.Send("Hi Admin!");
            admin.Send("Welcome Alice!");

            // Assert
            var actualOutput = output.ToString();
            Assert.Contains("[Alice]: Hi Admin!", actualOutput);
            Assert.Contains("[Admin]: Welcome Alice!", actualOutput);
        }

        [Fact]
        public void TestAdminSystemMessaging()
        {
            // Arrange
            IChatRoomMediator chatRoom = new ChatRoom();
            var admin = new Admin("Admin", chatRoom);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            admin.SendSystemMessage("This is a system message.");

            // Assert
            var actualOutput = output.ToString();
            Assert.Contains("[Admin]: [SYSTEM] This is a system message.", actualOutput);
        }
    }
}
