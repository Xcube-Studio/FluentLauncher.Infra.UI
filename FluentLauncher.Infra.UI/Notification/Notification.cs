using System;

namespace FluentLauncher.Infra.UI.Notification;

public interface INotification
{
    NotificationType Type { get; }

    string Title { get; }

    string? Message { get; }

    bool IsClosable { get; }

    double Delay { get; }
}

public interface INotification<out TElement> : INotification
{
    TElement ConstructUI();
}

public enum NotificationType
{
    Info,
    Warning,
    Error,
    Success
}