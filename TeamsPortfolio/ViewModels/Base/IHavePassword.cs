using System.Security;

namespace TeamsPortfolio
{
    /// <summary>
    /// an interface for a class that can provide a secure password
    /// </summary>
    public interface IHavePassword
    {
        SecureString SecurePassword { get; }
    }
}
