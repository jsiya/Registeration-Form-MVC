using Microsoft.AspNetCore.Mvc;
using Validation_MVC.Models;
using Validation_MVC.Services;

namespace Validation_MVC.Controllers;

public class LoginController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
   
    [HttpPost]
    public IActionResult Index(User user)
    {
        if (!ModelState.IsValid)
        {
            user.Id = Guid.NewGuid();
            DbContext.Users.Add(user);
            return View();
        }
        return RedirectToAction("Index", "Home");
    }
    
    
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(User user)
    {
        var logUser = DbContext.Users.FirstOrDefault(u => u.Username == user.Username);
        if (logUser is not null && logUser.Password == user.Password)
        {
            return RedirectToAction("Index", "Home");
        }
        return View();
    }
}