using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork_03.Models;

namespace HomeWork_03.Interfaces
{
 public interface IProductService
  {
    IEnumerable<ProductModel> GetList();

    ProductModel GetByID(int Id);

    void Save();

    void Add(ProductModel model);

    void Delete(int Id);
  }
}
