namespace CardGenerator.Services;

public interface ICardGeneratorService
{
    Task<GenericCardDto> GenerateNewCard();
}

public enum FunctionCardEnum
{
    Other = 0,
    Debit = 1,
    Credit = 2,
    Food = 3,
    Meal = 4
}

public enum HierarchyOfCard
{
    Default = 0,
    Gold = 1,
    Platinum = 2,
    Black = 3
}