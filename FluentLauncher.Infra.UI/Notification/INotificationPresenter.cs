namespace FluentLauncher.Infra.UI.Notification;

public interface INotificationPresenter
{
    void Show(INotification notification);

    void Close(INotification notification);

    void Clear();
}
