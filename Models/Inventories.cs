namespace StoreManager.Models;
using System.ComponentModel.DataAnnotations;

public class Inventories
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Endereço")]
    [StringLength(50, ErrorMessage = "O campo Endereço pode ter no máximo 50 caracteres")]
    public String? Address { get; set; }

    [Required(ErrorMessage = "Preencha o campo Capacidade")]
    public int? Capacity { get; set; }

    public Inventories()
    {
        
    }

    public Inventories(int id, string address, int capacity)
    {
        Id = id;
        Address = address;
        Capacity = capacity;
    }
}