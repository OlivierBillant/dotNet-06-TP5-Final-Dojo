namespace TpDojo.Dal.Entities;

using System.ComponentModel.DataAnnotations;

public class Samourai
{
    public int Id { get; set; }

    public int Force { get; set; }

    [Required]
    public string Nom { get; set; }

    public Arme? Arme { get; set; }
}
