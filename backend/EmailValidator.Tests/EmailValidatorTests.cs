using Xunit;
using EmailValidatorLib;

namespace EmailValidator.Tests
{
    public class EmailValidatorTests
    {
        [Theory]
        [InlineData("user@example.com", true)]
        [InlineData("user.name+tag@example.co.uk", true)]
        [InlineData("user@sub.domain.com", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("plainaddress", false)]
        [InlineData("user@.com", false)]
        [InlineData("user@domain.verylongtldtoolong", true)] // test a revisar según requirement
        public void IsValid_BasicCases_ReturnsExpected(string? email, bool expected)
        {
            var result = EmailValidator.IsValid(email);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsValid_TooLong_ReturnsFalse()
        {
            var local = new string('a', 200);
            var domain = new string('b', 50) + ".com";
            var email = $"{local}@{domain}";
            Assert.False(EmailValidator.IsValid(email));
        }
    }
}
