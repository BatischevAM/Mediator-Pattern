using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public interface IChatMediator
    {
        void SendMessage(string message, User sender, string receiverName);
        void AddUser(User user);
    }
}
