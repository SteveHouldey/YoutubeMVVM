/**
 * Relay COmmand .CS - Created by Steven Houldey
 * 
 * This file was created by Steven Houldey for a youtube video.
 * Full Code is aviliable on Github - see the link below:
 * 
 * No Liabilty will be taken for any mishap to your computer / infrastructure by using this program.....
 * 
 * If you find this useful, please give me a thumbs up and leave a comment....
 * 
 * 
 * Licensed under MIT. - Free to use ;)
 * 
 */

using System.Windows.Input;

namespace YoutubeMVVM.Functions
{
    public class RelayCommand : ICommand
    {
        Action<object> _executeMethod;
        Func<object, bool> _canExecuteMethod;

        public RelayCommand(Action <object> executeMethod, Func<object, bool> canExecuteMethod)
        {
            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecuteMethod != null)
            {
                return _canExecuteMethod(parameter);
            }
            else { return false; }

        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            _executeMethod(parameter);
        }

        


    }
}
