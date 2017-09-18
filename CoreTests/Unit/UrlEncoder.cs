using System.Net;
using NUnit.Framework;

namespace CoreTests.Unit
{
    [TestFixture]
    public class UrlEncoder
    {
        [Test]
        public void when_paranenthese_are_in_query_it_signs_correctly()
        {
            const string text = "-_.!~*'()";
            const string expected = "-_.%21~%2A%27%28%29";

            Assert.AreEqual(expected, WebUtility.UrlEncode(text));
        }
    }
}