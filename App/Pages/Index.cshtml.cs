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
            _logger.LogInformation("you requested Index page.");

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if(i == 5)
                    {
                        throw new Exception("this is our demo exception.");
                    }
                    else
                    {
                        _logger.LogInformation("value of i is {i}", i);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "we caught an exception in Index page.");
            }
        }
    }
}