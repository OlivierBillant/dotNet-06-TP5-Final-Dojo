namespace TpDojo.Web.Models;

using System.ComponentModel.DataAnnotations;
using TpDojo.Business.Dto;

public class SamouraiFormViewModel
{
    public int Id { get; set; }

    [Required]
    public int Force { get; set; }

    [Required]
    public string Nom { get; set; } = string.Empty;

    public int? ArmeId { get; set; }

    internal static SamouraiFormViewModel FromSamouraiDto(SamouraiDto? samourai)
        => samourai is null
        ? new()
        : new SamouraiFormViewModel { Id = samourai.Id, Nom = samourai.Nom, Force = samourai.Force };

    internal static List<SamouraiFormViewModel> FromSamourais(List<SamouraiDto> samouraiDtos)
        => samouraiDtos.Select(FromSamouraiDto).ToList();

    internal static SamouraiDto ToSamouraiDto(SamouraiFormViewModel samouraiViewModel)
        => new() { Id = samouraiViewModel.Id, Nom = samouraiViewModel.Nom, Force = samouraiViewModel.Force };

}
