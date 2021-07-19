using System;
using System.Windows.Input;

namespace TeamsPortfolio
{
    public class RelayCommand : ICommand
    {
        #region private members

        private Action _action;

        #endregion

        #region public events

        /// <summary>
        /// the event thats triggered when the <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion

        #region constructor

        public RelayCommand(Action action)
        {
            _action = action;
        }

        #endregion

        #region methods

        /// <summary>
        /// a relay command can always execute. 
        /// if command is binded to a button, this method will determind its activation(activated or not.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            // this is saying anything can be executed
            return true;
        }

        /// <summary>
        /// executes the commands Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _action();
        }

        #endregion
    }
}
