using System;
using Xunit;
using WebApplicationHi.Controllers;
using FluentAssertions;
namespace WebApiTest
{
    public class WebApplicationHiFixture
    {
        [Fact]
        public void Hi_Test()
        {
            ValuesController valuesController = new ValuesController();
             var res= valuesController.Get("Hi");
            Assert.Equal("Hello", res.Value);
        }
        [Fact]
        public void Hello_Test()
        {
            ValuesController valuesController = new ValuesController();
            var res = valuesController.Get("Hello");
            Assert.Equal("Say Hi", res.Value);
        }
    }
}
