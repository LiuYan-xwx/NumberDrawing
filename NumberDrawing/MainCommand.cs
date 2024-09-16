using System.Windows.Input;

namespace NumberDrawing
{
    public class MainCommand : ICommand
    {
        readonly Action _execute;
        readonly Func<bool> _canExecute;
        public MainCommand(Action action, Func<bool> canExcute)
        {
            _canExecute = canExcute;
            _execute = action;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }
            else
            {
                return _canExecute();
            }
        }
        public void Execute(object parameter)
        {
            _execute();
        }
        public event EventHandler CanExecuteChanged;
    }
}
