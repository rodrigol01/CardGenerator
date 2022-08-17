using CardGenerator.Domain.Entities;
using CardGenerator.Domain.Interfaces;

namespace CardGenerator.Services.AbstractFactoryMethod;

public class CreditCardFactory : IGenerateCardFactory
{
    public async Task<IGenericCardEntity> GenerateNewCard()
    {
        return await Task.FromResult(new CreditCardEntity());
    }
}