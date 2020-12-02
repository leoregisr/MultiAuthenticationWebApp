using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace MultiAuthenticationWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IStringLocalizer<IndexModel> _stringLocalizer;

        public IndexModel (ILogger<IndexModel> logger,  IStringLocalizer<IndexModel> stringLocalizer)
        {
            _logger = logger;
            _stringLocalizer = stringLocalizer;
        }

        public void OnGet()
        {
            ViewData["Welcome"] = _stringLocalizer["Welcome"];
            ViewData["Learn about"] = _stringLocalizer["Learn about"];
            ViewData["building Web apps with ASP.NET Core"] = _stringLocalizer["building Web apps with ASP.NET Core"];
            ViewData["Home Page"] = _stringLocalizer["Home Page"];
        }
    }
}
