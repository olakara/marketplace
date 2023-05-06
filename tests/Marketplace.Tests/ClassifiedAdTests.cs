using FluentAssertions;
using Marketplace.Domain;

namespace Marketplace.Tests;

public class ClassifiedAdTests
{
    [Fact]
    public void Should_ThrowsException_When_IdNotProvided()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var ad = new ClassifiedAd(Guid.Empty);
        });
    }
    
    [Fact]
    public void Should_CreateAValidClassifiedAd_When_IdIsProvided()
    {
        
        var guid = Guid.NewGuid();
        var ad = new ClassifiedAd(guid);
        ad.Should().NotBeNull();
        ad.Id.Should().Be(guid);

    }
}