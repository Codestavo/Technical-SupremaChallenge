using Services.SupremaChallenge.ViewModels;

namespace Services.SupremaChallenge.SumAppService;

public class SumAppService : ISumAppService
{
    public SumNumberResponseViewModel SumNumber(int upto)
    {
        try
        {
            if (upto <= 0)
            {
                return CreateSumNumberResponse(false, 0, "Value should be an natural number");
            }
            
            var finalNumber = (upto * (upto + 1)) / 2;

            return CreateSumNumberResponse(true, finalNumber, null);
        }
        catch (Exception e)
        {
            return CreateSumNumberResponse(false, 0, e.Message);
        }
        
    }

    private SumNumberResponseViewModel CreateSumNumberResponse(bool success, int value, string? error)
    {
        return new SumNumberResponseViewModel
        {
            Success = success, 
            Value = value, 
            Error = error
        };
    }
}