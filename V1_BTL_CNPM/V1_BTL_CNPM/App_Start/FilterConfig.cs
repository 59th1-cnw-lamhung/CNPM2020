﻿using System.Web;
using System.Web.Mvc;

namespace V1_BTL_CNPM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
