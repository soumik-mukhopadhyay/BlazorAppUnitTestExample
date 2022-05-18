using Bunit;

namespace BlazorApp1UnitTest
{
    internal class Counter
    {
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
            button.Click();

            // Assert: Count should be 4
            component.MarkupMatches(@"<p>Current count: 4</p><button>Click me</button>");
        }
    }
}
