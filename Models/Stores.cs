namespace StoreManager.Models;
using System.ComponentModel.DataAnnotations;

public class Stores
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Nome")]
    [StringLength(50, ErrorMessage = "O campo Nome pode ter no máximo 50 caracteres")]
    public String? Name { get; set; }

    [Required(ErrorMessage = "Preencha o campo Endereço")]
    [StringLength(50, ErrorMessage = "O campo Endereço pode ter no máximo 50 caracteres")]
    public String? Address { get; set; }

    public Stores()
    {
        
    }

    public Stores(int id, string name, string address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
}