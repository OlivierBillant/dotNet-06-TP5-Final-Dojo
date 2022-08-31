using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpDojo.Business.Dto;
using TpDojo.Dal.Entities;
using TpDojo.Web.Models;

namespace TpDojo.Web.Models;

    public class ArtMartialViewModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string Display => $"{this.Nom})";

        internal static ArtMartialViewModel? FromArtMartialDto(ArtMartialDto? artMartialDto)
            => artMartialDto is null
            ? null
            : new ArtMartialViewModel { Id = artMartialDto.Id, Nom = artMartialDto.Nom};

        internal static List<ArtMartialViewModel> FromArtMartiaux(List<ArtMartialDto> artMartialDto)
            => artMartialDto.Select(FromArtMartialDto).ToList();

        internal static ArtMartialDto ToArtMartialDto(ArtMartialViewModel artMartialViewModel)
            => new() { Id = artMartialViewModel.Id, Nom = artMartialViewModel.Nom};
    }

