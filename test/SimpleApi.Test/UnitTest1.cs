using System;
using Xunit;
using SimpleApi.Controllers;

namespace SimpleApi.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {

            var returnValue = controller.Get(1);
            Assert.Equal("zzz",returnValue.Value); 
        }
        [Fact]
        public void Test1()
        {
        }
 
    }
}
