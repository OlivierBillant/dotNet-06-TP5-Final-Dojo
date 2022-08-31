using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpDojo.Business.Dto;
using TpDojo.Dal.Entities;

namespace TpDojo.Business.Dto
{
    public class ArtMartialDto
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        internal static ArtMartialDto? FromArtMartial(ArtMartial? artMartial)
       => artMartial is null
       ? null
       : new ArtMartialDto { Id = artMartial.Id, Nom = artMartial.Nom };

        internal static List<ArtMartialDto?> FromArtMartiaux(List<ArtMartial> artMartial)
            => artMartial.Select(FromArtMartial).ToList();

        internal static ArtMartial ToArtMartial(ArtMartialDto artMartialDto)
            => new() { Id = artMartialDto.Id, Nom = artMartialDto.Nom};
    }
}
