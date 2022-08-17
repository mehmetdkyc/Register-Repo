using Data.Entities;
using DataBusiness.Abstract;
using DataBusiness.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RegisterApp.Controllers
{
    public class RegisterController : Controller
    {
        private  IRegisterService registerService;

        public RegisterController()
        {
            registerService = new RegisterService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAccount(string userName, string password , string email, int phoneNumber)
        {
            //formdan dönen verilerle kayıt oluşturma.
            Users _user = new Users()
            {
                Username = userName,
                Password = password,
                Mailaddress = email,
                PhoneNumber = phoneNumber.ToString()
            };
            registerService.CreateUser(_user);
            
            return RedirectToAction("Index","Login");
        }
    }
}
