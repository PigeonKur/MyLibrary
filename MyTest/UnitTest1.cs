using MyLibrary;

namespace MyTest
{
    public class UnitTest1
    {
        [Fact]
        public void Factorial_ReturnsCorrectValue()
        {
            var obj = new Class1();
            int result = obj.Factorial(5);
            Assert.Equal(120, result);
        }

        [Fact]
        public void Factorial_ThrowsOnNegativeInput()
        {
            var obj = new Class1();
            Assert.Throws<ArgumentException>(() => obj.Factorial(-1));
        }

    }
}