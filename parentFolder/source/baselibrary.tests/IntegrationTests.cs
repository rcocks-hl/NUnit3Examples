using NUnit.Framework;
using System.Threading.Tasks;

[TestFixture(Category = "Integration")]
public class IntegrationTests
{
    [Test]
    public async Task ExpensiveTest()
    {
        await Task.Delay(250);
        TestContext.Write("Expensive!");
    }
}