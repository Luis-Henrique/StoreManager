using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class ClientsController : Controller
{
    public ClientsController()
    {

    }

    public IActionResult Index()
    {
        return View();
    }
}
