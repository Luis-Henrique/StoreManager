using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class ProductsController : Controller
{
    private readonly StoreManagerContext _context;
    public ProductsController(StoreManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Products);
    }

   public IActionResult Show(int id)
    {
        Products product = _context.Products.Find(id);

        if(product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Products product)
    {
        if(!ModelState.IsValid) 
        {
            return View(product);
        }

        _context.Products.Add(product);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Products product = _context.Products.Find(id);

        if(product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    [HttpPost]
    public IActionResult Update(Products product, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(product);
        }
        
        Products updateproduct = _context.Products.Find(product.Id);
        
        updateproduct.Name = product.Name;
        updateproduct.Description = product.Description;
        updateproduct.Price = product.Price;

        _context.Products.Update(updateproduct);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Products product = _context.Products.Find(id);

        if(product == null)
        {
            return NotFound();
        }
        
        _context.Products.Remove(_context.Products.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

}
