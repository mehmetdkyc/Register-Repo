using Data.Entities;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class RegisterRepository : IRegisterRepository
    {
        public Users CreateUser(Users user)
        {
            using (var db = new DataContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
                return user;
            }
        }
        public List<Users> GetUsers()
        {
            using (var db = new DataContext())
            {
                return db.Users.ToList();
            }
        }
    }
}
