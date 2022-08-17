using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness.Abstract
{
    public interface IRegisterService
    {
        List<Users> GetUsers();

        Users CreateUser(Users user);

    }
}
