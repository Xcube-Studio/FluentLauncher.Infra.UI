using System.Collections.Generic;

namespace FluentLauncher.Infra.UI.Notification;

public interface INotificationService
{
    List<INotificationPresenter> Presenters { get; }

    void Show<TElement>(INotification<TElement> notification);
}