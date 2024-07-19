using Services.SupremaChallenge.ViewModels;

namespace Services.SupremaChallenge.SumAppService;

public interface ISumAppService
{
    SumNumberResponseViewModel SumNumber(int upto);
}