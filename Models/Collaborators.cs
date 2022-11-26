namespace StoreManager.Models;
using System.ComponentModel.DataAnnotations;

public class Collaborators
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Nome")]
    [StringLength(50, ErrorMessage = "O campo Nome pode ter no máximo 50 caracteres")]
    public String? Name { get; set; }

    [Required(ErrorMessage = "Preencha o campo Cargo")]
    [StringLength(20, ErrorMessage = "O campo Cargo pode ter no máximo 20 caracteres")]
    public String? Function { get; set; }

    [Required(ErrorMessage = "Preencha o campo Gênero")]
    [StringLength(15, ErrorMessage = "O campo Gênero pode ter no máximo 15 caracteres")]
    public String? Gender { get; set; }

    public Collaborators()
    {
        
    }

    public Collaborators(int id, string name, string function, string gender)
    {
        Id = id;
        Name = name;
        Function = function;
        Gender = gender;
    }
}