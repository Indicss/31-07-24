using Xunit;

public class StringValidatorTests
{
    [Fact]
    public void IsValidEmail_ValidEmail_ReturnsTrue()
    {
        var result = StringValidator.IsValidEmail("test@example.com");
        Assert.True(result);
    }

    [Fact]
    public void IsValidEmail_InvalidEmail_ReturnsFalse()
    {
        var result = StringValidator.IsValidEmail("testexample.com");
        Assert.False(result);
    }

    [Fact]
    public void IsPhoneNumber_ValidPhoneNumber_ReturnsTrue()
    {
        var result = StringValidator.IsPhoneNumber("1234567890");
        Assert.True(result);
    }

    [Fact]
    public void IsPhoneNumber_InvalidPhoneNumber_ReturnsFalse()
    {
        var result = StringValidator.IsPhoneNumber("12345abcde");
        Assert.False(result);
    }
}
