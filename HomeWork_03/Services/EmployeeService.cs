using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork_03.Interfaces;
using HomeWork_03.Models;

namespace HomeWork_03.Services
{
  public class EmployeeService : IEmployeeService
  {

    private static List<EmployeeModel> m_Data;

    static EmployeeService()
    {
      m_Data = new List<EmployeeModel>();

      int id = 0;
      DateTime dob = new DateTime(1990, 1, 1);
      for(int i = 1; i < 10; i++)
      {
        id++;
        dob = dob.AddYears(2);
        string firstName = "Имя_" + i.ToString();
        string midleName = "Отчество_" + i.ToString();
        string lastName = "Фамилия_" + i.ToString();
        m_Data.Add(new EmployeeModel(id, firstName, midleName, lastName, dob));
      }
    }

    public static List<EmployeeModel> Data { get => m_Data; }

    public void Add(EmployeeModel model)
    {
      model.Id = Data.Max(e => e.Id) + 1;
      Data.Add(model);
    }

    public void Delete(int Id)
    {
      EmployeeModel model = GetByID(Id);
      if(model != null) Data.Remove(model);
    }

    public EmployeeModel GetByID(int Id)
    {
      return Data.FirstOrDefault(e => e.Id.Equals(Id));
    }

    public IEnumerable<EmployeeModel> GetList()
    {
      return Data;
    }

    public void Save()
    {
      //Сохранение в БД...
    }
  }
}
