using Microsoft.Extensions.DependencyInjection;
using Services.SupremaChallenge.SumAppService;

namespace Infra.CrossCutting.SupremaChallenge.SumRegistrable;

public class Registrable
{
    public static void RegisterServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ISumAppService, SumAppService>();
    }
}