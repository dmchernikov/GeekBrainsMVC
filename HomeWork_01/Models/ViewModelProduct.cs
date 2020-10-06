using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HomeWork_01.Models
{
  public class ViewModelProduct
  {

    public static List<ViewModelProduct> GetData()
    {
      List<ViewModelProduct> data = new List<ViewModelProduct>();

      int id = 0;
      double price = 1000;
      for(int i = 1; i < 10; i++)
      {
        id++;
        price += 100;
        string name = "Product " + i.ToString();
        string fullName = "Product full name " + i.ToString();
        string producer = "Producer " + i.ToString();

        data.Add(new ViewModelProduct(id, name, fullName, producer, price));
      }
      return data;
    }

    public ViewModelProduct(int id, string name, string fullName, string producer, double price)
    {
      Id = id;
      Name = name;
      FullName = fullName;
      Producer = producer;
      Price = price;
    }

    public int Id { get; set; }

    [Display(Description ="Наименование")]
    public string Name { get; set; }

    [Display(Description = "Полное наименование")]
    public string FullName { get; set; }
    public string Producer { get; set; }
    public double Price { get; set; }

  }
}
