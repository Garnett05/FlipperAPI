using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Data
{
    public interface IIconsUserRepo
    {
        bool SaveChanges();
        IEnumerable<IconsUser> GetAllIconsUser();
        IconsUser GetIconsUserById(int id);
        void CreateIconsUser(IconsUser iconsUser);
        void UpdateIconsUser(IconsUser iconsUser);
        void DeleteIconsUser(IconsUser iconsUser);
    }
}
