using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeWork_03.Models;
using HomeWork_03.Interfaces;
using Microsoft.AspNetCore.Razor.Language;

namespace HomeWork_03.ViewControllers
{
  //Переопределение маршрутизации всех actions для контроллера
  //[Route("RedefinedEmployee/[action]")]
  //Переопределение маршрутизации с переопределениями и для actions
  [Route("RedefinedEmployee")]
  public class EmployeeController : Controller
  {
    private readonly IEmployeeService m_Service;
    public EmployeeController(IEmployeeService service)
    {
      m_Service = service;
    }

    [Route("RedefinedList")]
    public IActionResult List()
    {
      return View(m_Service.GetList());
    }

    [Route("RedefinedDetails/{id}")]
    public IActionResult Details(int id)
    {
      //List<EmployeeModel> data = m_Service.GetList();
      //var result = from item in data where item.Id == id select item;
      //if(result.Count() == 0) return NotFound("Сотрудник по Id = " + id.ToString() + " - не найден.");

      EmployeeModel model = m_Service.GetByID(id);
      if(model == null) return NotFound("Сотрудник по Id = " + id.ToString() + " - не найден.");
      return View(model);
    }

    [HttpGet]
    [Route("RedefinedEdit/{id?}")]
    public IActionResult Edit(int? id)
    {
      if(id.HasValue)
      {
        var model = m_Service.GetByID(id.Value);
        if(model == null) return NotFound("Сотрудник по Id = " + id.ToString() + " - не найден.");

        return View(model);
      }
      else
        return View(new EmployeeModel());
    }

    [HttpPost]
    [Route("RedefinedEdit/{id?}")]
    public IActionResult Edit(EmployeeModel model)
    {
      if(model.Id > 0)
      {
        var item = m_Service.GetByID(model.Id);
        if(ReferenceEquals(item, null)) return NotFound("Сотрудник по Id = " + model.Id.ToString() + " - не найден.");

        item.FirstName = model.FirstName;
        item.MidleName = model.MidleName;
        item.LastName = model.LastName;
        item.DOB = model.DOB;
      }
      else
      {
        EmployeeModel item = new EmployeeModel();
        item.FirstName = model.FirstName;
        item.MidleName = model.MidleName;
        item.LastName = model.LastName;
        item.DOB = model.DOB;

        m_Service.Add(item);
      }
      m_Service.Save();
      return RedirectToAction("List", "Employee");
    }

    [Route("RedefinedDelete/{id?}")]
    public IActionResult Delete(int? id)
    {
      if(id.HasValue)
      {
        var model = m_Service.GetByID(id.Value);
        if(model == null) return NotFound("Сотрудник по Id = " + id.ToString() + " - не найден.");
        m_Service.Delete(id.Value);
      }
      return RedirectToAction("List", "Employee");
    }
  }
}
