using DataBusiness.Abstract;
using DataBusiness.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace RegisterApp.Controllers
{
    public class LoginController : Controller
    {
        private IRegisterService registerService;

        public LoginController()
        {
            registerService = new RegisterService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            //Login işlemi burada yapılıyor eğer kullanıcı varsa onu cookie atıyor yoksa login ekranında sabit kalıyor. Kullanıcı yok ise /Home diyerek gitmenizi engelleyen mantık
            //cookie kontrol ediyor startup.cste.
            var userCheck = registerService.GetUsers().FirstOrDefault(x=>x.Username==userName && x.Password==password);
            if(userCheck != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userName)
                };
                var useridentity=new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index");
        }
    }
}
