using CardGenerator.Domain.Interfaces;

namespace CardGenerator.Services.AbstractFactoryMethod;

public interface IGenerateCardFactory
{
    public Task<IGenericCardEntity> GenerateNewCard();
}