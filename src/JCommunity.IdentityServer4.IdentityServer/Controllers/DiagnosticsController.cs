using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using JCommunity.IdentityServer4.IdentityServer.Middleware;
using JCommunity.IdentityServer4.IdentityServer.Models;

namespace JCommunity.IdentityServer4.IdentityServer.Controllers
{
    [Authorize]
    [SecurityHeaders]
    public class DiagnosticsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = new DiagnosticsViewModel(await HttpContext.AuthenticateAsync());
            return View(model);
        }
    }
}