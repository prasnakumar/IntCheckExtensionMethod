using Extension_Method;
using System;
using Xunit;

namespace ExtensionProjectUnitTest
{
    public class UnitTest1
    {
     

        [Fact]
        public void checkNumber()
        {
            string value = "10";

            Assert.Equal("$10", value.ToCurrency());

        }

        [Fact]
        public void StringCheck()
        {
            string value = "prasanna";
            Assert.Throws<Exception>(()=>value.ToCurrency());
        }

        [Fact]
        public void StringCheckError()
        {
            string value = "$)$^";
            var ex= Assert.Throws<Exception>(() => value.ToCurrency());
            Assert.Equal("Value is not a number", ex.Message); 

        }
    }
}
