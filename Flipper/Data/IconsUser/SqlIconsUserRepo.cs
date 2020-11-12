using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Data
{
    public class SqlIconsUserRepo : IIconsUserRepo
    {
        private readonly IconsUserContext _context;
        
        public SqlIconsUserRepo(IconsUserContext context)
        {
            _context = context;
        }

        public void CreateIconsUser(IconsUser iconsUser)
        {
            if (iconsUser == null)
            {
                throw new ArgumentNullException(nameof(iconsUser));
            }
            _context.IconsUser.Add(iconsUser);
        }

        public void DeleteIconsUser(IconsUser iconsUser)
        {
            if (iconsUser == null)
            {
                throw new ArgumentNullException(nameof(iconsUser));
            }
            _context.IconsUser.Remove(iconsUser);
        }

        public IEnumerable<IconsUser> GetAllIconsUser()
        {
            return _context.IconsUser.ToList();
        }

        public IconsUser GetIconsUserById(int id)
        {
            return _context.IconsUser.FirstOrDefault(x => x.IdIconUser == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public void UpdateIconsUser(IconsUser iconsUser)
        {
        }
    }
}
