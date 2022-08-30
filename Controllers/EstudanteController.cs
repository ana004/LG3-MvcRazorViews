using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;
namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    // private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>();
    private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>{
        new EstudanteViewModel(1, "Maria da Silva", "Rua A", true),
        new EstudanteViewModel(2, "Carlos Márcio", "Rua B", true),
        new EstudanteViewModel(3, "Tânia Maria", "Rua C", false),
        new EstudanteViewModel(4, "Álvaro Braga", "Rua A", true)
    };

    public IActionResult Index()
    {
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id-1]);
    }
}