using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TeamsPortfolio
{
    /// <summary>
    /// a base view model that trigers Property Changed events
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// the event that is triggered when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// to trigger <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #region command helpers

        /// <summary>
        /// runs a command if the updating flag is not set
        /// if the flag is true (indicating the function is already running) then the action is not run
        /// if the flag is false (indicating no runnging function) then the action is run
        /// once the action is finished if it was run, then the flag is reset to false
        /// </summary>
        /// <param name="updatingFlag">the boolean property flag defining if the command is already running</param>
        /// <param name="action">the action to run if the command is not already running</param>
        /// <returns></returns>
        protected async Task RunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            // check if the flag property is true (meaning the function is already running)
            if (updatingFlag.GetPropertyValue())
            {
                return;
            }

            // set the property flag to true to indicate we are running
            updatingFlag.SetPropertyValue(true);

            try
            {
                // run the passed in action
                await action();
            }
            finally
            {
                // set the property flag back to false. not it's finished
                updatingFlag.SetPropertyValue(false);
            }

        }

        #endregion
    }
}
