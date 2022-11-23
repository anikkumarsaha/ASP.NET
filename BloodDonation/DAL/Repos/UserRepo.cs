using DAL.EF;
using DAL.Interfaces;
using DAL.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class UserRepo : IRepo<User, string, User>, IAuth
    {
        BloodDonationEntities db;
        internal UserRepo()
        {
            db = new BloodDonationEntities();
        }
        public User Add(User obj)
        {
            db.Users.Add(obj);
            return obj;
        }

        public User Authenticate(string uname, string pass)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            db.Users.Remove(db.Users.Find(id));
            return db.SaveChanges() > 0;
        }

        public bool Edit(User obj)
        {
            var ext = db.Users.Find(obj.Username);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(string id)
        {
            return db.Users.Find(id);
        }
    }
}
