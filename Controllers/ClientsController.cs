using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class ClientsController : Controller
{
    private readonly StoreManagerContext _context;
    public ClientsController(StoreManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Clients);
    }

    public IActionResult Show(int id)
    {
        Clients client = _context.Clients.Find(id);

        if(client == null)
        {
            return NotFound();
        }

        return View(client);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Clients client)
    {
        if(!ModelState.IsValid) 
        {
            return View(client);
        }

        _context.Clients.Add(client);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Clients client = _context.Clients.Find(id);

        if(client == null)
        {
            return NotFound();
        }

        return View(client);
    }

    [HttpPost]
    public IActionResult Update(Clients client, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(client);
        }
        
        Clients updateClient = _context.Clients.Find(client.Id);
        
        updateClient.Name = client.Name;
        updateClient.Gender = client.Gender;
        updateClient.Email = client.Email;
        updateClient.Number = client.Number;

        _context.Clients.Update(updateClient);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Clients client = _context.Clients.Find(id);

        if(client == null)
        {
            return NotFound();
        }
        
        _context.Clients.Remove(_context.Clients.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

}
