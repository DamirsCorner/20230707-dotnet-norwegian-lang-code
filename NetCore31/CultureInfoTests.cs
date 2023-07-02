using FluentAssertions;
using NUnit.Framework;

namespace NetCore31
{
    public class CultureInfoTests
    {
        [Test]
        public void NorwegianLanguageCodeIsNbInNetCore31()
        {
            var cultureInfo = new System.Globalization.CultureInfo("no-NO");

            cultureInfo.TwoLetterISOLanguageName.Should().Be("nb");
        }
    }
}