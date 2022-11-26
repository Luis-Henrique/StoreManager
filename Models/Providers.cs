namespace StoreManager.Models;
using System.ComponentModel.DataAnnotations;

public class Providers
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Nome")]
    [StringLength(50, ErrorMessage = "O campo Nome pode ter no máximo 50 caracteres")]
    public String? Name { get; set; }

    [Required(ErrorMessage = "Preencha o campo E-mail")]
    [StringLength(50, ErrorMessage = "O campo E-mail pode ter no máximo 50 caracteres")]
    public String? Email { get; set; }

    [Required(ErrorMessage = "Preencha o campo Número")]
    [StringLength(20, ErrorMessage = "O campo Número pode ter no máximo 20 caracteres")]
    public String? Number { get; set; }

    public Providers()
    {
        
    }

    public Providers(int id, string name, string gender, string email, string number)
    {
        Id = id;
        Name = name;
        Email = email;
        Number = number;
    }
}