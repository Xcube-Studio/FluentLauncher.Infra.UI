﻿using System;

namespace FluentLauncher.Infra.UI.Notification;

[AttributeUsage(AttributeTargets.Method)]
public class NotificationAttribute<TElement>() : Attribute
{
    public required string Title { get; set; }

    public string? Message { get; set; }

    public bool IsClosable { get; set; } = true;

    public double Delay { get; set; } = 5;

    public NotificationType Type { get; set; }
}


[AttributeUsage(AttributeTargets.Method)]
public class ExceptionNotificationAttribute : Attribute
{
    public required string Title { get; set; }

    public string? Message { get; set; }

    public double Delay { get; set; } = 30;
}