using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers;

public class UserController : Controller
{
    public IActionResult Index(){
        return View();
    } 
}

