﻿using System.Web;
using System.Web.Mvc;

namespace ngay8thang3_Complete
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
