using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API_Fornecedores.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }

    public IActionResult Criar()
    {
        return Criar();
    }

    public IActionResult Editar()
    {
        return Editar();
    }

    public IActionResult Apagar()
    {
        return Apagar();
    }

}

