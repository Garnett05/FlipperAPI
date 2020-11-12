using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Data
{
    public class SqlIconsGroupRepo : IIconsGroupRepo
    {
        private readonly IconsGroupContext _context;
        
        public SqlIconsGroupRepo(IconsGroupContext context)
        {
            _context = context;
        }

        public void CreateIconsGroup(IconsGroup iconsGroup)
        {
            if (iconsGroup == null)
            {
                throw new ArgumentNullException(nameof(iconsGroup));
            }
            _context.IconsGroup.Add(iconsGroup);
        }

        public void DeleteIconsGroup(IconsGroup iconsGroup)
        {
            if (iconsGroup == null)
            {
                throw new ArgumentNullException(nameof(iconsGroup));
            }
            _context.IconsGroup.Remove(iconsGroup);
        }

        public IEnumerable<IconsGroup> GetAllIconsGroup()
        {
            return _context.IconsGroup.ToList();
        }

        public IconsGroup GetIconsGroupById(int id)
        {
            return _context.IconsGroup.FirstOrDefault(x => x.IdIconGroup == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public void UpdateIconsGroup(IconsGroup iconsGroup)
        {
        }
    }
}
