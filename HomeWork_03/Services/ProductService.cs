using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork_03.Interfaces;
using HomeWork_03.Models;

namespace HomeWork_03.Services
{
  public class ProductService : IProductService
  {
    private static List<ProductModel> m_Data;

    static ProductService()
    {
      m_Data = new List<ProductModel>();
      int id = 0;
      double price = 1000;
      for(int i = 1; i < 30; i++)
      {
        id++;
        price += 100;
        string name = "Product " + i.ToString();
        string fullName = "Product full name " + i.ToString();
        string producer = "Producer " + i.ToString();

        m_Data.Add(new ProductModel(id, name, fullName, producer, price));
      }
    }

    public static List<ProductModel> Data { get => m_Data; }

    public void Add(ProductModel model)
    {
      model.Id = Data.Max(e => e.Id) + 1;
      Data.Add(model);
    }

    public void Delete(int Id)
    {
      ProductModel model = GetByID(Id);
      if(model != null) Data.Remove(model);
    }

    public ProductModel GetByID(int Id)
    {
      return Data.FirstOrDefault(e => e.Id.Equals(Id));
    }

    public IEnumerable<ProductModel> GetList()
    {
      return Data;
    }

    public void Save()
    {
      //Сохранение в БД...
    }
  }
}
