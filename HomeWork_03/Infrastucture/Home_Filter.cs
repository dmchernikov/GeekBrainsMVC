using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HomeWork_03.Infrastucture
{
  //Фильтр наследуется от Attribute и поддерживает интерфейс IActionFilter
  //Для controller навешивается аттрибут (см. Home)
  public class Home_Filter : Attribute, IActionFilter
  {
    public void OnActionExecuting(ActionExecutingContext context)
    {
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {      
    }
  }
}
