namespace csharp.training.congruent.tests
{
    public class DoubleTest
    {
        public static double Floor(double value, double step)
        {
            return Math.Floor(value / step) * step;
        }
        [Fact]
        public void TestDouble()
        {
            Double value = .1;
            Double result1 = value * 10;
            Double result2 = 0;
            for (int ctr = 1; ctr <= 10; ctr++)
                result2 += value;
            Assert.True(result1 == result2, $"Expected 1 but got {result2}");
        }
        [Fact]
        public void TestDoubleEquality()
        {

            int decimals = 6;
            double value = 5F;
            double step = 2F;
            double expected = 4F;
            double actual = Floor(value, step);
            Assert.True(actual == expected, $"Expected {expected} but got {actual}");
            value = -11.5F;
            step = 1.1F;
            expected = -12.1F;
            actual = Floor(value, step);
            Assert.True(Math.Round(expected, decimals) ==
            Math.Round(actual, decimals), $"Expected {Math.Round(expected, decimals)} but got {Math.Round(actual, decimals)}");
            Assert.True(Math.Abs(expected - actual) < Math.Pow(10, -decimals), $"Expected {expected} but got {actual}");
            Assert.True(expected == actual, $"Expected {expected} but got {actual}");

        }

    }
}
