namespace StoreManager.Models;
using System.ComponentModel.DataAnnotations;

public class Products
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Nome")]
    [StringLength(50, ErrorMessage = "O campo Nome pode ter no máximo 50 caracteres")]
    public String? Name { get; set; }

    [Required(ErrorMessage = "Preencha o campo Descrição")]
    [StringLength(50, ErrorMessage = "O campo Descrição pode ter no máximo 50 caracteres")]
    public String? Description { get; set; }

    [Required(ErrorMessage = "Preencha o campo Valor")]
    public int? Price { get; set; }

    public Boolean? Active { get; set; }

    public Products()
    {
        
    }

    public Products(int id, string name, string description, int price, Boolean active)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Active = active;
    }
}