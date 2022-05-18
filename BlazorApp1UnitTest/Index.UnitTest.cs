using Bunit;

namespace BlazorApp1UnitTest
{
    public class Index
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// bUnit basics.
        /// </summary>
        [Test]
        public void SimpleComponentTest()
        {
            // Arrange : render the razor component
            using var context = new Bunit.TestContext();
            var renderComponent = context.RenderComponent<BlazorApp1.Pages.Index>();

            // Act : find and click the <button> element to increment
            renderComponent.Find("button").Click();

            // Assert : first find the <h5> element, then verify its content
            renderComponent.Find("h5").MarkupMatches("<h5>Blazor component is clicked.</h5>");
        }
    }
}