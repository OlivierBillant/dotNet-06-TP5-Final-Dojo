namespace TpDojo.Dal.Entities;

using System.ComponentModel.DataAnnotations;

public class Samourai : ADataObject
{
    public int Force { get; set; }

    [Required]
    public string Nom { get; set; }
    public Arme? Arme { get; set; }

    public int ArmeId { get; set; }
    public List<ArtMartial> ArtMartiaux { get; set; } = new();
}
