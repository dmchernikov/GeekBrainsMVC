using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeWork_03.Models;
using HomeWork_03.Interfaces;

namespace HomeWork_03.ViewControllers
{
  public class ProductController : Controller
  {
    private readonly IProductService m_Service;

    public ProductController(IProductService service)
    {
      m_Service = service;
    }

    public IActionResult List()
    {
      return View(m_Service.GetList());
    }

    public IActionResult Details(int id)
    {
      ProductModel model = m_Service.GetByID(id);
      if(model == null) return NotFound("Товар по Id = " + id.ToString() + " - не найден.");
      return View(model);
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
      if(id.HasValue)
      {
        var model = m_Service.GetByID(id.Value);
        if(model == null) return NotFound("Товар по Id = " + id.ToString() + " - не найден.");

        return View(model);
      }
      else
        return View(new ProductModel());
    }

    [HttpPost]
    public IActionResult Edit(ProductModel model)
    {
      if(model.Id > 0)
      {
        var item = m_Service.GetByID(model.Id);
        if(ReferenceEquals(item, null)) return NotFound("Сотрудник по Id = " + model.Id.ToString() + " - не найден.");

        item.Name = model.Name;
        item.FullName = model.FullName;
        item.Producer = model.Producer;
        item.Price = model.Price;
      }
      else
      {
        ProductModel item = new ProductModel();
        item.Name = model.Name;
        item.FullName = model.FullName;
        item.Producer = model.Producer;
        item.Price = model.Price;

        m_Service.Add(item);
      }
      m_Service.Save();
      return RedirectToAction("List", "Product");
    }

    public IActionResult Delete(int? id)
    {
      if(id.HasValue)
      {
        var model = m_Service.GetByID(id.Value);
        if(model == null) return NotFound("Товар по Id = " + id.ToString() + " - не найден.");
        m_Service.Delete(id.Value);
      }
      return RedirectToAction("List", "Product");
    }
  }
}