using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Data
{
    public class SqlGroupsxUsersRepo : IGroupsxUsersRepo
    {
        private readonly GroupsxUsersContext _context;
        
        public SqlGroupsxUsersRepo(GroupsxUsersContext context)
        {
            _context = context;
        }

        public void CreateGroupsxUsers(GroupsxUsers groupsxUsers)
        {
            if (groupsxUsers == null)
            {
                throw new ArgumentNullException(nameof(groupsxUsers));
            }
            _context.GroupsxUsers.Add(groupsxUsers);
        }

        public void DeleteGroupsxUsers(GroupsxUsers groupsxUsers)
        {
            if (groupsxUsers == null)
            {
                throw new ArgumentNullException(nameof(groupsxUsers));
            }
            _context.GroupsxUsers.Remove(groupsxUsers);
        }

        public IEnumerable<GroupsxUsers> GetAllGroupsxUsers()
        {
            return _context.GroupsxUsers.ToList();
        }

        public GroupsxUsers GetGroupsxUsersById(int id)
        {
            return _context.GroupsxUsers.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public void UpdateGroupsxUsers(GroupsxUsers groupsxUsers)
        {
        }
    }
}
