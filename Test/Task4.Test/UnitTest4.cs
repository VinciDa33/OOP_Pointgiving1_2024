namespace Task4.Test;

public class Tests
{
    [Test]
    public void Division_WithPositiveInteger_ReturnsDoubledValue()
    {
       double inputOne = 12.0;
       double inputTwo = 1.5;
       double expectedOutput = 8;
       
       double actualOutput = Program.Divide(inputOne, inputTwo);

       Assert.IsTrue(expectedOutput == actualOutput);
    }

    [Test]
    public void Division_WithNegativeInteger_ReturnsDoubledValue()
    {
        double inputOne = -192.0;
        double inputTwo = -4;
        double expectedOutput = 48;

        double actualOutput = Program.Divide(inputOne, inputTwo);

        Assert.IsTrue(expectedOutput == actualOutput);
    }
    
    [Test]
    public void Division_WithOneNegativeInteger_ReturnsDoubledValue()
    {
        double inputOne = 18.0;
        double inputTwo = -3;
        double expectedOutput = -6;

        double actualOutput = Program.Divide(inputOne, inputTwo);

        Assert.IsTrue(expectedOutput == actualOutput);
    }
    
}