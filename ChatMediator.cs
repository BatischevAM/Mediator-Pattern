using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public class ChatMediator : IChatMediator
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
            user.SetMediator(this);
        }

        public void SendMessage(string message, User sender, string receiverName)
        {
            User receiver = _users.Find(u => u.Name == receiverName);
            if (receiver != null)
            {
                receiver.ReceiveMessage(message, sender.Name);
            }
            else
            {
                Console.WriteLine($"Пользователь {receiverName} не найден.");
            }
        }
    }
}
