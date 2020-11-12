using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Data
{
    public interface IMessagesRepo
    {
        bool SaveChanges();
        IEnumerable<Messages> GetAllMessages();
        Messages GetMessagesById(int id);
        void CreateMessages(Messages messages);
        void UpdateMessages(Messages messages);
        void DeleteMessages(Messages messages);
    }
}
