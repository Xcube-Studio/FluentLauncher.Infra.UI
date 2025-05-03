using System;

namespace FluentLauncher.Infra.UI.Notification;

[AttributeUsage(AttributeTargets.Method)]
public class NotificationAttribute<TElement>() : Attribute
{
    public required string Title { get; set; }

    public string? Message { get; set; }

    public bool IsClosable { get; set; } = true;

    public NotificationType Type { get; set; }
}
