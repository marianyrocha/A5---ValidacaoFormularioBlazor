using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Components.Models;

public class Produto
{
    
    [Required(ErrorMessage = "O campo Nome deve ser preenchido")]
    public string Nome { get; set; } = "";
    
    [Range(0.01, 999999999, ErrorMessage = "Informe um valor válido") ]
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
}