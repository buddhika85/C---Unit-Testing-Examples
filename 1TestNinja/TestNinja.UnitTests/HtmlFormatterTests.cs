using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests 
    {
        [Test]
        public void Test_ShouldEnclosedWithInStrongTag()
        {
            // arrange
            var htmlFormatter = new HtmlFormatter();
            var text = "abc";
            
            // act
            var result = htmlFormatter.FormatAsBold(text);

            // assert
            Assert.That(result, Is.EqualTo($"<strong>{text}</strong>"));    // specific 

            // general assertions which tests sections of the result
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain(text));
        }
    }
}
