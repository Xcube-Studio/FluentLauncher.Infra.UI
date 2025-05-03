namespace FluentLauncher.Infra.UI.Notification;

public interface INotificationService
{
    INotificationPresenter InfoBar { get; }

    INotificationPresenter System { get; }

    INotificationPresenter TeachingTip { get; }
}