﻿using Microsoft.AspNetCore.Mvc;

namespace ManageBooks.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
