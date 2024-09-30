using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        // Act
        string actual  = CamelCaseConverter.ConvertToCamelCase(input);
        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange
        string input = "test";
        // Act
        string actual = CamelCaseConverter.ConvertToCamelCase(input);
        string expected = "test";
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange
        string input = "once upon a time there was";
        // Act
        string actual = CamelCaseConverter.ConvertToCamelCase(input);
        string expected = "onceUponATimeThereWas";
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange
        string input = "ThE raIn IS poUring OuTsIdE";
        // Act
        string actual = CamelCaseConverter.ConvertToCamelCase(input);
        string expected = "theRainIsPouringOutside";
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
