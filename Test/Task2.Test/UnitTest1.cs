namespace Task2.Test;


public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.IsTrue(Program.MultipliedNumber(2) == 4);
    }

    [Test]
    public void TestNegativeNumbers()
    {
        Assert.IsTrue(Program.MultipliedNumber(-2) == -4);
    }

    [Test]
    public void TestMultiplyByZero()
    {
        Assert.IsTrue(Program.MultipliedNumber(0) == 0);
    }
}