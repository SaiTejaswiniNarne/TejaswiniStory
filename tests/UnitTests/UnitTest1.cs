using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
         public void Area_Workswithtwopositivenumbers()
        {
            var expected =100.0;
            var a = 20.0;
            var b = 10.0;
            var actual = Area(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(100.0,20.0,10.0)]
        [InlineData(25.0, 5.0,10.0)]
        [InlineData(0.0, 0.0,0.0)]
        public void Area_WorksWithManyInputs(double exp, double n1, double n2)
        {
            Assert.Equal(exp, Area(n1, n2));
        }
        double Area(double a,double b){
                return 0.5*a*b;
            }
    }
}
