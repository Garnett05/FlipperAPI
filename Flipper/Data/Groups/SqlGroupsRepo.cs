using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Data
{
    public class SqlGroupsRepo : IGroupsRepo
    {
        private readonly GroupsContext _context;
        
        public SqlGroupsRepo(GroupsContext context)
        {
            _context = context;
        }

        public void CreateGroup(Groups group)
        {
            if (group == null)
            {
                throw new ArgumentNullException(nameof(group));
            }
            _context.Groups.Add(group);
        }

        public void DeleteGroup(Groups group)
        {
            if (group == null)
            {
                throw new ArgumentNullException(nameof(group));
            }
            _context.Groups.Remove(group);
        }

        public IEnumerable<Groups> GetAllGroups()
        {
            return _context.Groups.ToList();
        }

        public Groups GetGroupById(int id)
        {
            return _context.Groups.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public void UpdateGroup(Groups group)
        {
        }
    }
}
