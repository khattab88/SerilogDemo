using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Log.Information("you requested Index page.");

            try
            {
                throw new Exception("this is our demo exception.");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "we caught an exception in Index page.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}