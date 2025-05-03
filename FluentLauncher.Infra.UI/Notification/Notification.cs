namespace FluentLauncher.Infra.UI.Notification;

public interface INotification
{
    NotificationType Type { get; }

    string Title { get; }

    string? Message { get; }
}

public enum NotificationType
{
    Info,
    Warning,
    Error,
    Success
}