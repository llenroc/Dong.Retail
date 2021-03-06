﻿using Abp.AspNetCore.Mvc.ViewComponents;

namespace Dong.Retail.Web.Public.Views
{
    public abstract class RetailViewComponent : AbpViewComponent
    {
        protected RetailViewComponent()
        {
            LocalizationSourceName = RetailConsts.LocalizationSourceName;
        }
    }
}