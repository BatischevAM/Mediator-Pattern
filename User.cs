using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public class User
    {
        public string Name { get; private set; }
        private IChatMediator _mediator;
        private List<string> _messageHistory = new List<string>();

        public User(string name)
        {
            Name = name;
        }

        public void SetMediator(IChatMediator mediator)
        {
            _mediator = mediator;
        }

        public void SendMessage(string message, string receiverName)
        {
            Console.WriteLine($"{Name} отправляет сообщение '{message}' пользователю {receiverName}");
            _mediator.SendMessage(message, this, receiverName);
            _messageHistory.Add($"Отправлено: {message} пользователю {receiverName}");
        }

        public void ReceiveMessage(string message, string senderName)
        {
            Console.WriteLine($"{Name} получил сообщение от {senderName}: '{message}'");
            _messageHistory.Add($"Получено от {senderName}: {message}");
        }

        public void ShowMessageHistory()
        {
            Console.WriteLine($"\nИстория сообщений для {Name}:");
            foreach (var msg in _messageHistory)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
