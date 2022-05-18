using Bunit;

namespace BlazorApp1UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            using var context = new Bunit.TestContext();

            // Act
            var renderComponent = context.RenderComponent<BlazorApp1.Pages.Index>();
            renderComponent.Find("button").Click();

            // Assert
            renderComponent.Find("h5").MarkupMatches("<h5>Blazor component is clicked.</h5>");
        }
    }
}