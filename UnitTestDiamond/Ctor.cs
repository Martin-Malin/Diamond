namespace UnitTestDiamond
{
    [TestClass]
    public class Ctor
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NonAlphabetic_ThrowsArgumentOutOfRangeException()
        {
            var diamond = new Diamond.Diamond("0");
        }
    }
}