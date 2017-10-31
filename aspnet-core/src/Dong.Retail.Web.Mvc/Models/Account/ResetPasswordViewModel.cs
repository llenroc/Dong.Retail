﻿using System.ComponentModel.DataAnnotations;
using Dong.Retail.Security;

namespace Dong.Retail.Web.Models.Account
{
    public class ResetPasswordViewModel
    {
        public int? TenantId { get; set; }

        [Range(1, long.MaxValue)]
        public long UserId { get; set; }

        [Required]
        public string ResetCode { get; set; }

        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public string ReturnUrl { get; set; }

        public string SingleSignIn { get; set; }
    }
}