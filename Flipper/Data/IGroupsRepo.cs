using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Data
{
    public interface IGroupsRepo
    {
        bool SaveChanges();
        IEnumerable<Groups> GetAllGroups();
        Groups GetGroupById(int id);
        void CreateGroup(Groups group);
        void UpdateGroup(Groups group);
        void DeleteGroup(Groups group);
    }
}
