namespace TpDojo.Dal.Entities;

using System.ComponentModel.DataAnnotations;

public class Arme
{
    public int Id { get; set; }

    [Required]
    public string Nom { get; set; }

    public int Degats { get; set; }
}