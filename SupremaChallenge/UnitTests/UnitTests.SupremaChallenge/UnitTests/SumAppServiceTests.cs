using Services.SupremaChallenge.SumAppService;
namespace UnitTests.SupremaChallenge.UnitTests;
using Xunit;

public class SumAppServiceTests
{
    private readonly ISumAppService _sumAppService;

    public SumAppServiceTests()
    {
        _sumAppService = new SumAppService();
    }

    [Fact]
    public void SumNumber_ReturnsError_ForNonNaturalNumber()
    {
        // Arrange
        const int invalidNumber = 0;

        // Act
        var result = _sumAppService.SumNumber(invalidNumber);

        // Assert
        Assert.NotNull(result);
        Assert.False(result.Success);
        Assert.Equal(0, result.Value);
        Assert.Equal("Value should be an natural number", result.Error);
    }

    [Fact]
    public void SumNumber_ReturnsCorrectSum_ForValidNumber()
    {
        // Arrange
        const int validNumber = 5;

        // Act
        var result = _sumAppService.SumNumber(validNumber);

        // Assert
        Assert.NotNull(result);
        Assert.True(result.Success);
        Assert.Equal(15, result.Value);
        Assert.Null(result.Error);
    }
}
