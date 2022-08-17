using CardGenerator.Services.Dtos;
using CardGenerator.Services.Interfaces;

namespace CardGenerator.Services;

public class CardGeneratorService : ICardGeneratorService
{
    public Task<GenericCardDto> GenerateNewCard(int personId, bool canGenerate)
    {
        throw new NotImplementedException();
    }
}