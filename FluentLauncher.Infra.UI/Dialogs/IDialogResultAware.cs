namespace FluentLauncher.Infra.UI.Dialogs;

/// <summary>
/// Interface for a dialog that can produce a result.
/// </summary>
public interface IDialogResultAware<out T>
{
    /// <summary>
    /// The result of the dialog.
    /// </summary>
    T? Result { get; }
}
