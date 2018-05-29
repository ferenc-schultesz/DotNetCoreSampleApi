using System;
using System.Linq;
using DotNetCoreSampleApi.Controllers;
using Xunit;

namespace DotNetCoreSampleApi.Tests
{
	public class ValuesControllerTest
    {
        [Fact]
		public void Get_Should_Return_Value1_And_Value2()
        {
			var controller = new ValuesController();
			var values = controller.Get().ToList();

			Assert.True(values.Contains("Congratulations,"), "value1 is not returned");
			Assert.True(values.Contains("You managed to setup CircleCI and Heroku for CI and CD! ..again"),
			            "value2 is not returned: " + values[1]);
        }
    }
}
