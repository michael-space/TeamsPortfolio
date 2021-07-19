using System;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TeamsPortfolio
{
    /// <summary>
    /// the View Model for a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region public properties

        /// <summary>
        /// the email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// a flag indicating if the login command is runnging
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region commands

        public ICommand LoginCommand { get; set; }

        #endregion

        #region constructor

        public LoginViewModel()
        {
            // not good to rely on passing parameters
            // but for getting around for a passwordbox issue, this is the solution.
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
        }

        /// <summary>
        /// attempts to log the user in
        /// </summary>
        /// <param name="parameter">the <see cref="SecureString"/>passed in from the view for the users password</param>
        /// <returns></returns>
        private async Task Login(object parameter)
        {
            await RunCommand(() => LoginIsRunning, async () => 
            {
                await Task.Delay(5000);

                var email = Email;

                // CAUTION: never store unsecure password in variable like this.
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
            });            
        }

        #endregion
    }
}
