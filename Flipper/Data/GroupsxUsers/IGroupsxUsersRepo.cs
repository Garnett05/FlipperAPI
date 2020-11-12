using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Data
{
    public interface IGroupsxUsersRepo
    {
        bool SaveChanges();
        IEnumerable<GroupsxUsers> GetAllGroupsxUsers();
        GroupsxUsers GetGroupsxUsersById(int id);
        void CreateGroupsxUsers(GroupsxUsers groupsxUsers);
        void UpdateGroupsxUsers(GroupsxUsers groupsxUsers);
        void DeleteGroupsxUsers(GroupsxUsers groupsxUsers);
    }
}
