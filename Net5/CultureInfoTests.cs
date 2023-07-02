using FluentAssertions;
using NUnit.Framework;

namespace Net5
{
    public class CultureInfoTests
    {
        [Test]
        public void NorwegianLanguageCodeIsNoInNet5()
        {
            var cultureInfo = new System.Globalization.CultureInfo("no-NO");

            cultureInfo.TwoLetterISOLanguageName.Should().Be("no");
        }
    }
}