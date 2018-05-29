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
        
		[Fact]
        public void Get_values_with_id_should_return_message_with_id()
        {
            var controller = new ValuesController();

            var values = controller.Get(1);
            Assert.True(values.Contains("1"), "1 is not returned from Get with Id");
			values = controller.Get(2);
            Assert.True(values.Contains("2"), "2 is not returned from Get with Id");
			values = controller.Get(6);
            Assert.True(values.Contains("6"), "6 is not returned from Get with Id");
			values = controller.Get(34);
            Assert.True(values.Contains("34"), "34 is not returned from Get with Id");
			values = controller.Get(9999);
            Assert.True(values.Contains("9999"), "9999 is not returned from Get with Id");
			values = controller.Get(43);
            Assert.True(values.Contains("43"), "43 is not returned from Get with Id");
        }

    }
}
