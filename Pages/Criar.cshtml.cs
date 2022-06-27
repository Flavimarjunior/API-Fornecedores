using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API_Fornecedores.Pages;

public class CriarModel : PageModel
{
    private readonly ILogger<CriarModel> _logger;

    public CriarModel(ILogger<CriarModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}