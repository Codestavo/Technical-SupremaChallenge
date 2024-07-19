using Microsoft.AspNetCore.Mvc;
using Services.SupremaChallenge.SumAppService;
using Services.SupremaChallenge.ViewModels;

namespace Application.SupremaChallenge.Controllers;

[Route("/sum")]
public class SumController : ControllerBase
{

    private readonly ISumAppService _sumAppService;
    
    public SumController(ISumAppService sumAppService)
    {
        _sumAppService = sumAppService;
    }

    [HttpPost]
    public SumNumberResponseViewModel SumNumbers([FromQuery] int upto)
    {
        return _sumAppService.SumNumber(upto);
    }
}