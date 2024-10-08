namespace Task2.Test;


public class Tests
{
    [Test]
    public void TestPositiveNumber()
    {
        Assert.IsTrue(Program.MultiplyAndReturn(2) == 4);
        Assert.IsTrue(Program.MultiplyAndReturn(35) == 70);
        Assert.IsTrue(Program.MultiplyAndReturn(10) == 20);
        Assert.IsTrue(Program.MultiplyAndReturn(102) == 204);
    }

    [Test]
    public void TestNegativeNumbers()
    {
        Assert.IsTrue(Program.MultiplyAndReturn(-2) == -4);
        Assert.IsTrue(Program.MultiplyAndReturn(-6) == -12);
        Assert.IsTrue(Program.MultiplyAndReturn(-177) == -354);
        Assert.IsTrue(Program.MultiplyAndReturn(-10) == -20);

    }

    [Test]
    public void TestMultiplyByZero()
    {
        Assert.IsTrue(Program.MultiplyAndReturn(0) == 0);
    }
}