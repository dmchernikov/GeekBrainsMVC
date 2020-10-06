using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HomeWork_01.Models
{
  public class ViewModelEmployee
  {
    public static List<ViewModelEmployee> GetData()
    {
      List<ViewModelEmployee> data = new List<ViewModelEmployee>();

      int id = 0;
      DateTime dob = new DateTime(1990, 1, 1);
      for(int i = 1; i < 10; i++)
      {
        id++;
        dob = dob.AddYears(2);
        string firstName = "Имя " + i.ToString();
        string midleName = "Отчество" + i.ToString();
        string lastName = "Фамилия " + i.ToString();

        data.Add(new ViewModelEmployee(id, firstName, midleName, lastName, dob));
      }
      return data;
    }

    public ViewModelEmployee(int id, string firstName, string midleName, string lastName, DateTime dob)
    {
      Id = id;
      FirstName = firstName;
      MidleName = midleName;
      LastName = lastName;
      DOB = dob;
    }

    [Display(Name = "ID")]
    public int Id { get; set; }

    [Display(Name = "Имя")]
    public string FirstName { get; set; }

    [Display(Name = "Отчество")]
    public string MidleName { get; set; }

    [Display(Name = "Фамилия")]
    public string LastName { get; set; }

    [Display(Name = "Дата рождения")]
    public DateTime DOB { get; set; }
  }
}
