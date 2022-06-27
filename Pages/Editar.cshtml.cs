using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API_Fornecedores.Pages;

public class EditarModel : PageModel
{
    private readonly ILogger<EditarModel> _logger;

    public EditarModel(ILogger<EditarModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}