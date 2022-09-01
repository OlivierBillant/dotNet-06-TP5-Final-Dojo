namespace TpDojo.Web.Models;

using TpDojo.Business.Dto;
using TpDojo.Dal.Entities;

public class SamouraiViewModel
{
    public int Id { get; set; }
    public int Force { get; set; }
    public string Nom { get; set; }
    public ArmeViewModel? Arme { get; set; }
    public List<ArtMartialViewModel>? ArtMartiaux { get; set; }

    public string ArmeDisplay => this.Arme switch
    {
        null => "Aucune arme",
        _ => this.Arme.Display
    };

    public string ArtMartialDisplay => this.ArtMartiaux.Count switch
    {
        0 => "Aucun art martial disponible",
        _ => string.Join(", ", this.ArtMartiaux.Select(i => i.Nom))
    };

    internal static SamouraiViewModel FromSamouraiDto(SamouraiDto? samourai)
        => samourai is null
        ? new()
        : new SamouraiViewModel { Id = samourai.Id, Nom = samourai.Nom, Force = samourai.Force, Arme = ArmeViewModel.FromArmeDto(samourai.Arme), ArtMartiaux = ArtMartialViewModel.FromArtMartiaux(samourai.ArtMartiaux) };

    internal static List<SamouraiViewModel> FromSamourais(List<SamouraiDto> samouraiDtos)
        => samouraiDtos.Select(FromSamouraiDto).ToList();

    internal static SamouraiDto ToSamouraiDto(SamouraiViewModel samouraiViewModel)
        => new() { Id = samouraiViewModel.Id, Nom = samouraiViewModel.Nom, Force = samouraiViewModel.Force };

}
