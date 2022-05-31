using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using my_website.Utils;

namespace my_website.Pages;

public class IndexModel : PageModel
{
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
                _logger = logger;
        }

        public void OnGetMyOnClick()
        {
                BashExecutionner.ExecuteCommand("bash /mnt/services/web/my-website/update_webservice.sh");
                // BashExecutionner.ExecuteCommand("touch ~/temp2.txt");
        }

}
