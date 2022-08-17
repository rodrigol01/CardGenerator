using CardGenerator.Services.Dtos;

namespace CardGenerator.Services.Interfaces;

public interface ICardGeneratorService
{
    Task<GenericCardDto> GenerateNewCard(int personId);
}