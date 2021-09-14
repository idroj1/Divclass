using NUnit.Framework;

namespace Clist.tests
{
    public class Tests
    {
        /*
        
        */

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GLib_Test()
        {
            var Person = new List<string>();
            var Topic = new List<string>()
            {
                "TP1", "TP2", "TP3"
            };

            Assert.IsEmpty(Collection GroupList(Person, Topic));
        }
        
        [Test]
        public void TestLib()
        {
            Assert.Pass();
        }
    }
}