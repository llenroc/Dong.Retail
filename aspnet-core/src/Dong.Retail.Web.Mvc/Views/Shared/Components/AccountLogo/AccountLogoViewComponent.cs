﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dong.Retail.Web.Session;

namespace Dong.Retail.Web.Views.Shared.Components.AccountLogo
{
    public class AccountLogoViewComponent : RetailViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AccountLogoViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            return View(new AccountLogoViewModel(loginInfo));
        }
    }
}
