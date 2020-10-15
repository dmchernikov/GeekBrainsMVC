using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace HomeWork_03.Models
{
  public class ProductModel
  {
    public ProductModel(int id, string name, string fullName, string producer, double price)
    {
      Id = id;
      Name = name;
      FullName = fullName;
      Producer = producer;
      Price = price;
    }

    public ProductModel() : this(0, "", "", "", 0) { }

    [Display(Name = "ID")]
    public int Id { get; set; }

    [Display(Name ="Наименование")]
    public string Name { get; set; }

    [Display(Name = "Полное наименование")]
    public string FullName { get; set; }

    [Display(Name = "Производитель")]
    public string Producer { get; set; }

    [Display(Name = "Цена")]
    public double Price { get; set; }

  }
}
