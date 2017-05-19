/// <summary>
/// WebAPI-Tutorial
/// https://github.com/ajmaltahir/WebAPI-Tutorial
/// 
/// Created by Ajmal Tahir
/// Copyright © 2017 Ajmal Tahir. All rights reserved.
/// </summary>

using System.Web;
using System.Web.Mvc;

namespace App.WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
