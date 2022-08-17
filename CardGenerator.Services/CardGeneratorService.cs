using CardGenerator.Services.AbstractFactoryMethod;
using CardGenerator.Services.Dtos;
using CardGenerator.Services.Interfaces;

namespace CardGenerator.Services;

public class CardGeneratorService : ICardGeneratorService
{
    private readonly IGenerateCardFactory _generateCardFactory;

    public CardGeneratorService(IGenerateCardFactory generateCardFactory)
    {
        _generateCardFactory = generateCardFactory;
    }

    public async Task<GenericCardDto> GenerateNewCard(int personId)
    {
        var card = await _generateCardFactory.GenerateNewCard();

        return null;
    }
}