using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API_Fornecedores.Pages;

public class ApagarModel : PageModel
{
    private readonly ILogger<ApagarModel> _logger;

    public ApagarModel(ILogger<ApagarModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}