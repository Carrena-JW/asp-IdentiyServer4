using System.Threading.Tasks;
using JCommunity.IdentityServer4.IdentityServer.Models;

namespace JCommunity.IdentityServer4.IdentityServer.Services;

public interface IAccountService
{
    Task<LoginViewModel> BuildLoginViewModelAsync(string returnUrl);
    LoginViewModel BuildLinkLoginViewModel(string returnUrl);
    Task<LoginViewModel> BuildLoginViewModelAsync(LoginInputModel model);
    Task<LogoutViewModel> BuildLogoutViewModelAsync(string logoutId);
    Task<LoggedOutViewModel> BuildLoggedOutViewModelAsync(string logoutId);
    RegisterViewModel BuildRegisterViewModel();
    RegisterViewModel BuildRegisterViewModel(RegisterInputModel model, bool success);
}