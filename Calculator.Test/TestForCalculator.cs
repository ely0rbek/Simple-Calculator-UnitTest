namespace Calculator.Test
{
    public class TestForCalculator
    {

        //Qoshish
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(5,2,7)]
        [InlineData(14,45,3)]
        [InlineData(10,21,31)]
        public void TestForQoshish(double a, double b, double expectedResult)
            => Assert.Equal(expectedResult, Matem.Qoshish(a,b));



        //Ayirish
        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(4, 2, 7)]
        [InlineData(48, 45, 3)]
        [InlineData(100, 21, 79)]
        public void TestForAyirish(double a, double b, double expectedResult)
            => Assert.Equal(expectedResult, Matem.Ayirish(a, b));


        //Kopaytirish
        [Theory]
        [InlineData(5, 2, 1)]
        [InlineData(4, 2, 8)]
        [InlineData(8, 5, 40)]
        [InlineData(10, 21, 210)]
        public void TestForKopaytirish(double a, double b, double expectedResult)
            => Assert.Equal(expectedResult, Matem.Kopaytirish(a, b));


        //Bolish
        [Theory]
        [InlineData(12, 2, 6)]
        [InlineData(16, 2, 8)]
        [InlineData(200, 5, 40)]
        [InlineData(10, 21, 5)]
        public void TestForBolish(double a, double b, double expectedResult)
            => Assert.Equal(expectedResult, Matem.Bolish(a, b));
    }
}