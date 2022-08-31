namespace TpDojo.Business;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TpDojo.Business.Dto;
using TpDojo.Dal.Abstractions;
using TpDojo.Dal.Entities;

public class ArtMartialService
{
    private readonly IArtMartialAccessLayer artMartialAccessLayer;

    public ArtMartialService(IArtMartialAccessLayer artMartialAccessLayer)
    {
        this.artMartialAccessLayer = artMartialAccessLayer;
    }

    public async Task<List<ArtMartialDto>> GetArtMartiauxAsync()
    {
        var artMartiaux = await this.artMartialAccessLayer.GetAllAsync();
        return ArtMartialDto.FromArtMartiaux(artMartiaux);
    }

    public async Task<bool> ArtMartialExistsAsync(int id)
        => await this.artMartialAccessLayer.ExistsAsync(id);

    public async Task<ArtMartialDto> GetArtMartialByIdAsync(int? id)
    {
        var artMartial = await this.artMartialAccessLayer.GetByIdAsync(id);
        return ArtMartialDto.FromArtMartial(artMartial);
    }

    public async Task AddArtMartialAsync(ArtMartialDto artMartialDto)
    {
        var artMartial = ArtMartialDto.ToArtMartial(artMartialDto);
        await this.artMartialAccessLayer.AddAsync(artMartial);
    }

    public async Task UpdateArtMartialAsync(ArtMartialDto artMartialDto)
    {
        var artMartial = ArtMartialDto.ToArtMartial(artMartialDto);
        await this.artMartialAccessLayer.UpdateAsync(artMartial);
    }

    public async Task RemoveArtMartialAsync(int id)
    {
        await this.artMartialAccessLayer.RemoveAsync(id);
    }
}
