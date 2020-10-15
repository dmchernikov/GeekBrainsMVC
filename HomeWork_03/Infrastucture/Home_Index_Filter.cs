using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HomeWork_03.Infrastucture
{
  //Фильтр наследуется от Attribute и поддерживает интерфейс IActionFilter
  //Для action навешивается аттрибут (см. Home/Index)
  public class Home_Index_Filter : Attribute, IActionFilter
  {
    public void OnActionExecuting(ActionExecutingContext context)
    {    
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {    
    }
  }
}
