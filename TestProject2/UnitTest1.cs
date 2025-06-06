using NUnit.Framework;

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test1()
        {   
            var kal = new Kalkulator();

            Assert.AreEqual(5, kal.LeggSammen(2, 3));
            Assert.AreNotEqual(2,kal.Multipliser(3, 4));
            Assert.False(kal.TrekkFra(3,5) == 2);
            Assert.Throws<ArgumentException>(() => { kal.Divider(3, 0); });
        }
    }
}