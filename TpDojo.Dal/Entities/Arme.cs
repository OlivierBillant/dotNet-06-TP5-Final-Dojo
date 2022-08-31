namespace TpDojo.Dal.Entities;

using System.ComponentModel.DataAnnotations;

public class Arme : ADataObject
{
    [Required]
    public string Nom { get; set; }

    public int Degats { get; set; }

    public Samourai Samourai { get; set; }
}