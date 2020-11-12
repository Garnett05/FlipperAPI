using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Data
{
    public class SqlMessagesRepo : IMessagesRepo
    {
        private readonly MessagesContext _context;
        
        public SqlMessagesRepo(MessagesContext context)
        {
            _context = context;
        }

        public void CreateMessages(Messages messages)
        {
            if (messages == null)
            {
                throw new ArgumentNullException(nameof(messages));
            }
            _context.Messages.Add(messages);
        }

        public void DeleteMessages(Messages messages)
        {
            if (messages == null)
            {
                throw new ArgumentNullException(nameof(messages));
            }
            _context.Messages.Remove(messages);
        }

        public IEnumerable<Messages> GetAllMessages()
        {
            return _context.Messages.ToList();
        }

        public Messages GetMessagesById(int id)
        {
            return _context.Messages.FirstOrDefault(x => x.IdMsg == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public void UpdateMessages(Messages messages)
        {
        }
    }
}
