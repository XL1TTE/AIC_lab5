using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AIC_LAB5.Client.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Predicate<object?> _predicate;
        private readonly Action<object?> _action;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object?> action, Predicate<object?> predicate)
        {
            _predicate = predicate;
            _action = action;
        }
        public bool CanExecute(object? parameter)
        {
            return _predicate(parameter);
        }

        public void Execute(object? parameter)
        {
            _action.Invoke(parameter);
        }
    }
}
