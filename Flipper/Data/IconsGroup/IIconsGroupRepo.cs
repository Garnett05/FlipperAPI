using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Data
{
    public interface IIconsGroupRepo
    {
        bool SaveChanges();
        IEnumerable<IconsGroup> GetAllIconsGroup();
        IconsGroup GetIconsGroupById(int id);
        void CreateIconsGroup(IconsGroup iconsGroup);
        void UpdateIconsGroup(IconsGroup iconsGroup);
        void DeleteIconsGroup(IconsGroup iconsGroup);
    }
}
