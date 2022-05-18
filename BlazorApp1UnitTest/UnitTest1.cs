using Bunit;

namespace BlazorApp1UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// bUnit basics.
        /// </summary>
        [Test]
        public void SimpleTestComponent()
        {
            // Arrange : render the razor component
            using var context = new Bunit.TestContext();
            var renderComponent = context.RenderComponent<BlazorApp1.Pages.Index>();

            // Act : find and click the <button> element to increment
            renderComponent.Find("button").Click();

            // Assert : first find the <h5> element, then verify its content
            renderComponent.Find("h5").MarkupMatches("<h5>Blazor component is clicked.</h5>");
        }

        /// <summary>
        /// Testing component parameters.
        /// </summary>
        [Test]
        public void CounterComponentTest()
        {
            // Arrange
            using var context = new Bunit.TestContext();
            var component = context.RenderComponent<BlazorApp1.Pages.Counter>();
            component.SetParametersAndRender(parameters => parameters.Add(p => p.Increment, 2));

            // Act
            var button = component.Find("button");
            button.Click();

            // Assert: Count should be 4
            component.MarkupMatches(@"<p>Current count: 2</p><button>Click me</button>");
        }
    }
}