using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class ProvidersController : Controller
{
    private readonly StoreManagerContext _context;
    public ProvidersController(StoreManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Providers);
    }

    public IActionResult Show(int id)
    {
        Providers provider = _context.Providers.Find(id);

        if(provider == null)
        {
            return NotFound();
        }

        return View(provider);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Providers provider)
    {
        if(!ModelState.IsValid) 
        {
            return View(provider);
        }

        _context.Providers.Add(provider);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Providers provider = _context.Providers.Find(id);

        if(provider == null)
        {
            return NotFound();
        }

        return View(provider);
    }

    [HttpPost]
    public IActionResult Update(Providers provider, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(provider);
        }
        
        Providers updateProvider = _context.Providers.Find(provider.Id);
        
        updateProvider.Name = provider.Name;
        updateProvider.Email = provider.Email;
        updateProvider.Number = provider.Number;

        _context.Providers.Update(updateProvider);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Providers provider = _context.Providers.Find(id);

        if(provider == null)
        {
            return NotFound();
        }
        
        _context.Providers.Remove(_context.Providers.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

}
