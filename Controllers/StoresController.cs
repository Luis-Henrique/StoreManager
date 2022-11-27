using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class StoresController : Controller
{
 private readonly StoreManagerContext _context;
    public StoresController(StoreManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Stores);
    }

    public IActionResult Show(int id)
    {
        Stores store = _context.Stores.Find(id);

        if(store == null)
        {
            return NotFound();
        }

        return View(store);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Stores store)
    {
        if(!ModelState.IsValid) 
        {
            return View(store);
        }

        _context.Stores.Add(store);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Stores store = _context.Stores.Find(id);

        if(store == null)
        {
            return NotFound();
        }

        return View(store);
    }

    [HttpPost]
    public IActionResult Update(Stores store, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(store);
        }
        
        Stores updatestore = _context.Stores.Find(store.Id);
        
        updatestore.Name = store.Name;
        updatestore.Address = store.Address;

        _context.Stores.Update(updatestore);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Stores store = _context.Stores.Find(id);

        if(store == null)
        {
            return NotFound();
        }
        
        _context.Stores.Remove(_context.Stores.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

}
