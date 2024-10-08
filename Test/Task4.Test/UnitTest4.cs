namespace Task4.Test;

public class Tests
{
    [Test]
    public void MultipliedNumber_WithPositiveInteger_ReturnsDoubledValue()
    {
        int input = 5;
        int expectedOutput = 10;


        int actualOutput = Program.MultipliedNumber(input);
        
        Assert.IsTrue(expectedOutput == actualOutput);
    }

    [Test]
    public void MultipliedNumber_WithNegativeInteger_ReturnsDoubledValue()
    {
        int input = -3;
        int expectedOutput = -6;


        int actualOutput = Program.MultipliedNumber(input);


        Assert.IsTrue(expectedOutput == actualOutput);
    }

    [Test]
    public void MultipliedNumber_WithZero_ReturnsZero()
    {
        
        int input = 0;
        int expectedOutput = 0;

        
        int actualOutput = Program.MultipliedNumber(input);

        
        Assert.IsTrue(expectedOutput == actualOutput);
    }
}