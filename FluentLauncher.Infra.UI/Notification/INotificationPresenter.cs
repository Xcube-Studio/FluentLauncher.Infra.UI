namespace FluentLauncher.Infra.UI.Notification;

public interface INotificationPresenter
{
    void Clear();
}

public interface INotificationPresenter<TElement> : INotificationPresenter
{
    void Show(INotification<TElement> notification);

    void Close(INotification<TElement> notification);
}