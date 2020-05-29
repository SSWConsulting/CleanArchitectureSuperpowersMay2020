using Xunit;

namespace CaWorkshop.Application.UnitTests
{
    [CollectionDefinition(nameof(QueryFixture))]
    public class QueryFixture : ICollectionFixture<TestFixture>
    { }
}