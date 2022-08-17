
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRegisterRepository
    {
        List<Users> GetUsers();

        Users CreateUser(Users user);


    }
}
