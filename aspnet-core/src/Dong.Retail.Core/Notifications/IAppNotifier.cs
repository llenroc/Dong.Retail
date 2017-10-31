﻿using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using Dong.Retail.Authorization.Users;
using Dong.Retail.MultiTenancy;

namespace Dong.Retail.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
