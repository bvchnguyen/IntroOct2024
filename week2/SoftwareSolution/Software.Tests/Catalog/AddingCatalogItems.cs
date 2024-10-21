using Alba;
using Software.Api.Catalog;

namespace Software.Tests.Catalog;
public class AddingCatalogItems
{
    [Fact]
    public async Task AddingAnItemToTheCatalogAsync()
    {
        var host = await AlbaHost.For<Program>();

        var request = new CatalogCreateModel
        {
            Title = "Rider",
            Vendor = "JetTrains",
            IsOpenSource = false
        };


        var reponse = new CatalogResponseModel
        {
            Id = Guid.Empty,
            Title = "Rider",
            Vendor = "JetTrains",
            IsOpenSource = false
        };

        await host.Scenario(api =>
        {
            api.Post.Url("/catalog");
            api.StatusCodeShouldBeOk();
        });
    }
}