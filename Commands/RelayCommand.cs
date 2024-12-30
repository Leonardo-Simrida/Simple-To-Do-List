using System.Windows.Input;

namespace Simple_To_Do_List.Commands;
public class RelayCommand : ICommand
{
    public Action<object> Execute { get; set; }
    public Predicate<object> CanExecute { get; set; }

    public RelayCommand(Action<object> ExecuteMethod, Predicate<object> CanExecuteMethod)
    {
        Execute = ExecuteMethod;
        CanExecute = CanExecuteMethod;
    }

    public event EventHandler? CanExecuteChanged;

    bool ICommand.CanExecute(object? parameter)
    {
        return CanExecute(parameter);
    }

    void ICommand.Execute(object? parameter)
    {
        Execute(parameter);
    }
}
