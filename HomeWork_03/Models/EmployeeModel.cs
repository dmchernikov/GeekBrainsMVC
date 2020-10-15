using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HomeWork_03.Models
{
  public class EmployeeModel
  {
    public EmployeeModel(int id, string firstName, string midleName, string lastName, DateTime dob)
    {
      Id = id;
      FirstName = firstName;
      MidleName = midleName;
      LastName = lastName;
      DOB = dob;
    }

    public EmployeeModel() : this(0, "", "", "", DateTime.MinValue) { }

    [Display(Name = "ID")]
    public int Id { get; set; }

    [Display(Name = "Имя")]
    public string FirstName { get; set; }

    [Display(Name = "Отчество")]
    public string MidleName { get; set; }

    [Display(Name = "Фамилия")]
    public string LastName { get; set; }

    [Display(Name = "Дата рождения")]
    //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime DOB { get; set; }
  }
}
