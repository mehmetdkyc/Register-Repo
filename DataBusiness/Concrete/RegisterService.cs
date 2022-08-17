using Data.Entities;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataBusiness.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness.Concrete
{
    public class RegisterService : IRegisterService
    {
        private readonly IRegisterRepository _registerService;

        public RegisterService()
        {
            _registerService= new RegisterRepository();
        }
        public Users CreateUser(Users user)
        {
            return _registerService.CreateUser(user);
        }

        public List<Users> GetUsers()
        {
            return _registerService.GetUsers();
        }
    }
}
