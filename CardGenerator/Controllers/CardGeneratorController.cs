using CardGenerator.Dtos;
using CardGenerator.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CardGenerator.Controllers;

[ApiController]
[Route("[controller]")]
public class CardGeneratorController : ControllerBase
{
    private readonly ICardGeneratorService _cardGeneratorService;

    public CardGeneratorController(ICardGeneratorService cardGeneratorService)
    {
        _cardGeneratorService = cardGeneratorService;
    }

    [HttpPost("GenerateNewCard")]
    public async Task<IActionResult> GenerateNewCard([FromBody] CardGeneratorDto cardGeneratorDto)
    {
        var newCard =
            await _cardGeneratorService.GenerateNewCard(cardGeneratorDto.PersonId, cardGeneratorDto.CanGenerateCard);

        return Ok(newCard);
    }
}