using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DelegateOperationsWebApp.Pages
{
public class FraseModel : PageModel
{
public delegate void FraseDelegate(string frase);
 [BindProperty]
  public string FraseInput { get; set; }
  public string ResultadoMaiusculas { get; set; }
  public string ResultadoMinusculas { get; set; }
  public void OnPost()
{
  FraseDelegate imprimirMaiusculas = (frase) => ResultadoMaiusculas = frase.ToUpper();
  FraseDelegate imprimirMinusculas = (frase) => ResultadoMinusculas = frase.ToLower();
    imprimirMaiusculas(FraseInput);
    imprimirMinusculas(FraseInput);
     }
  }
}
