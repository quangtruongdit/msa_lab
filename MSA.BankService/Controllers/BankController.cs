using Microsoft.AspNetCore.Mvc;
using MSA.BankService.Domain;

namespace MSA.BankService.Controllers;

[ApiController]
[Route("[controller]")]
public class BankController : ControllerBase
{
    private static readonly string[] BankNames = new[]
    {
        "Bank 1", "Bank 2", "Bank 3", "Bank 4", "Bank 5"
    };

    private readonly ILogger<BankController> _logger;

    public BankController(ILogger<BankController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBanks")]
    public IEnumerable<Bank> Get()
    {
        return Enumerable.Range(0, 5).Select(index => new Bank
        {
            Code = index,
            Name = BankNames[index]
        })
        .ToArray();
    }
}
