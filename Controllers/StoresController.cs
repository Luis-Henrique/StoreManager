using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class StoresController : Controller
{
    public StoresController()
    {

    }

    public IActionResult Index()
    {
        return View();
    }
}
