using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StoryGenerator.Models;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    private readonly GeneradorHistoriasService _generadorService;

    [BindProperty]
    public string? GeneroSeleccionado { get; set; }

    public SelectList? Generos { get; set; }

    public Historia? HistoriaGenerada { get; set; }

    public IndexModel(GeneradorHistoriasService generadorService)
    {
        _generadorService = generadorService;
    }

    public void OnGet()
    {
        Generos = new SelectList(_generadorService.ObtenerGeneros());
    }

    public IActionResult OnPost()
    {
        if (!string.IsNullOrEmpty(GeneroSeleccionado))
        {
            HistoriaGenerada = _generadorService.GenerarHistoria(GeneroSeleccionado);
        }

        Generos = new SelectList(_generadorService.ObtenerGeneros());
        return Page();
    }
}