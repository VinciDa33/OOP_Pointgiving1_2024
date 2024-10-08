namespace Task4.Test;

public class Tests
{
    [Test]
    public void Division_WithPositiveInteger_ReturnsDoubledValue()
    {
       double inputOne = 12.0;
       double inputTwo = 1.5;
       
       double expectedOutput = 8;
       
       double actualOutput = Program.Division(inputOne, inputTwo);

       Assert.IsTrue(expectedOutput == actualOutput);
    }

    [Test]
    public void Division_WithNegativeInteger_ReturnsDoubledValue()
    {
        double inputOne = -12.0;
        double inputTwo = -1.5;
        double expectedOutput = 8;


        double actualOutput = Program.Division(inputOne, inputTwo);


        Assert.IsTrue(expectedOutput == actualOutput);
    }
    
    [Test]
    public void Division_WithOneNegativeInteger_ReturnsDoubledValue()
    {
        double inputOne = 12.0;
        double inputTwo = -1.5;
        double expectedOutput = -8;


        double actualOutput = Program.Division(inputOne, inputTwo);


        Assert.IsTrue(expectedOutput == actualOutput);
    }
    
}