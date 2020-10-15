using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork_03.Models;

namespace HomeWork_03.Interfaces
{
  public interface IEmployeeService
  {
    IEnumerable<EmployeeModel> GetList();

    EmployeeModel GetByID(int Id);

    void Save();

    void Add(EmployeeModel model);

    void Delete(int Id);
  }
}
