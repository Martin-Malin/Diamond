namespace UnitTestDiamond
{
    [TestClass]
    public class ToString
    {
        [TestMethod]
        public void A()
        {
            var diamond = new Diamond.Diamond("A");

            var expected = "A";

            Assert.AreEqual(expected, diamond.ToString());
        }

        [TestMethod]
        public void B()
        {
            var diamond = new Diamond.Diamond("B");

            var expected =
                " A\r\n" +
                "B B\r\n" +
                " A";

            Assert.AreEqual(expected, diamond.ToString());
        }

        [TestMethod]
        public void C()
        {
            var diamond = new Diamond.Diamond("C");

            var expected =
                "  A\r\n" +
                " B B\r\n" +
                "C   C\r\n" +
                " B B\r\n" +
                "  A";

            Assert.AreEqual(expected, diamond.ToString());
        }

        [TestMethod]
        public void D()
        {
            var diamond = new Diamond.Diamond("D");

            var expected =
                "   A\r\n" +
                "  B B\r\n" +
                " C   C\r\n" +
                "D     D\r\n" +
                " C   C\r\n" +
                "  B B\r\n" +
                "   A";

            Assert.AreEqual(expected, diamond.ToString());
        }

        [TestMethod]
        public void E()
        {
            var diamond = new Diamond.Diamond("E");

            var expected =
                "    A\r\n" +
                "   B B\r\n" +
                "  C   C\r\n" +
                " D     D\r\n" +
                "E       E\r\n" +
                " D     D\r\n" +
                "  C   C\r\n" +
                "   B B\r\n" +
                "    A";

            Assert.AreEqual(expected, diamond.ToString());
        }
    }
}
