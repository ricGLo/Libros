using System.ComponentModel.DataAnnotations;

namespace Libros.Shared.Models;

public class CheckoutForm
{
    [Required(ErrorMessage = "Introduce tu nombre")]
    public string Name { get; set; } = "";
    [Required(ErrorMessage = "Introduce tu dirección")]
    public string Address { get; set; } = "";
}