namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


        const string Expected = "Hello World!";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.Hello();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);

            }
        }

            [TestMethod]
            public void TestMethod2()
        {


        const string Expected = "Goodbye";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.GoodBye();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}