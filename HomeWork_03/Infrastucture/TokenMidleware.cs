using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HomeWork_03.Infrastucture
{
  public class TokenMidleware
  {
    //Обязательное свойство для классов Midleware !!!
    public RequestDelegate Next { get; }

    //Инициализируем в конструкторе свойство Next
    public TokenMidleware(RequestDelegate next)
    {
      Next = next;
    }

    //Пример бизнес логики для InvokeAsync
    private const string CorrectToken = "CorrectToken";

    //Обязательный метод для классов Midleware !!!
    //Асинхронный
    public async Task InvokeAsync(HttpContext context)
    {
      //Пример: Ожидаемый Token
      var token = context.Request.Query["token"];

      //Нет Token - передаем запрос дальше по конвейеру
      if(string.IsNullOrEmpty(token))
      {
        await Next.Invoke(context);
      }
      //Обрабатываем по нашей бизнес логике и дальше передаем запрос по конвейеру
      else if(token == CorrectToken)
      {
        //Обработка...


        await Next.Invoke(context);
      }
      else
      {
        await context.Response.WriteAsync("Token not correct!");
      }
    }

    //Синхронный
    //public Task Invoke(HttpContext context)
    //{
    //  //Пример: Ожидаемый Token
    //  var token = context.Request.Query["CorrectToken"];

    //}
  }
}
